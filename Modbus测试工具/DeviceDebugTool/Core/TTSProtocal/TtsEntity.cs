// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TtsEntity.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary>
//   The tts entity.  create version by chenqi
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DeviceDebugTool.Core.TTSProtocal
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using NewLife;
    using NewLife.Model;
    using NewLife.Reflection;
    using NewLife.Serialization;

    /// <summary>
    /// The tts entity.
    /// </summary>
    public class TtsEntity
    {
        #region Fields


        /// <summary>
        /// The _ extend data.
        /// </summary>
        [NonSerialized]
        [FieldSize("_DataLength")]
        private List<byte> _ExtendData;

        /// <summary>
        /// The _ function.
        /// </summary>
        [NonSerialized]
        private TtsFunction _Function;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="TtsEntity"/> class.
        /// </summary>
        static TtsEntity()
        {
            Init();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsEntity"/> class.
        /// </summary>
        public TtsEntity()
        {
            this._ExtendData = new List<byte>();

            Header = 0xFD;
            // 默认功能码为命成语音
            this._Function = TtsFunction.SpeechSynthesis;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// 数据区
        /// </summary>
        public List<byte> ExtendData
        {
            get
            {
                return this._ExtendData;
            }

            set
            {
                this._ExtendData = value;
            }
        }

        /// <summary>
        /// 命令字
        /// </summary>
        public TtsFunction Function
        {
            get
            {
                return this._Function;
            }

            set
            {
                this._Function = value;
            }
        }

        /// <summary>
        /// 包头 0xFD
        /// </summary>
        public byte Header { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// 将数据区按各自的要求进行转换
        /// </summary>
        public virtual void CalculateExtendData()
        {
            throw new NotImplementedException("CalculateExtendData");
        }

        /// <summary>
        /// 序列化为数据流
        /// </summary>
        /// <returns>
        /// The <see cref="Stream"/>.
        /// </returns>
        public Stream GetStream()
        {
            var ms = new MemoryStream();
            this.Write(ms);
            ms.Position = 0;
            return ms;
        }

        /// <summary>
        /// 从流中读取消息
        /// </summary>
        /// <param name="stream">
        /// </param>
        /// <returns>
        /// The <see cref="EntityBase"/>.
        /// </returns>
        public static TtsEntity Read(Stream stream)
        {
            Stream ms = stream;

            long start = ms.Position;
            var reader = new BinaryReaderX(ms);
            Set(reader);
            SetDebug(reader);

            ms.Position = 0;

            // 读取命令码
            var function = (TtsFunction)reader.ReadByte();
            ms.Position = start;

            // 读取了响应类型和消息类型后，动态创建消息对象
            Type type = ObjectContainer.Current.ResolveType<IResponse>(function);
            TtsEntity entity = null;
            try
            {
                entity = reader.ReadObject(type) as TtsEntity;
            }
            catch (Exception ex)
            {
                throw new XException(string.Format("无法从数据流中读取{0}（Function={1}）消息！", type.Name, "TtsEntity"), ex);
            }

            if (entity == null)
            {
                return null;
            }

            ms.Position = 0;
            entity.ExtendData = ms.ReadBytes().ToList();
            return entity;
        }

        /// <summary>
        /// 从流中读取消息
        /// </summary>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <param name="stream">
        /// </param>
        /// <returns>
        /// The <see cref="TEntity"/>.
        /// </returns>
        public static TEntity Read<TEntity>(Stream stream) where TEntity : TtsEntity
        {
            return Read(stream) as TEntity;
        }

        /// <summary>
        /// The set args.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public virtual void SetArgs(params object[] args)
        {
            throw new NotImplementedException("SetArgs");

            // if (args.Length == 1)
            // SubCmd = (LType.SubCmdType)Enum.Parse(typeof(LType.SubCmdType), args[0].ToString());
        }

        /// <summary>
        /// 把当前对象写入数据，包括可能的起始符和结束符
        /// </summary>
        /// <param name="stream">
        /// </param>
        public void Write(Stream stream)
        {
            // Default模式，先写入内存流
            var ms = new MemoryStream();
            var writer = new BinaryWriterX(ms);
            Set(writer);
            writer.Settings.IsLittleEndian = false;
            ms.Position = 0;

            //writer.WriteObject(this);
            writer.Write(Header);

            List<byte> dt = this.ExtendData;
            if (dt != null && dt.Count > 0)
            {
                writer.Write(dt.ToArray<byte>(), 0, dt.Count);
            }

            ms.Position = 0;
            byte[] data = ms.ReadBytes();
            writer.Stream = stream;
            //writer.Write(data, 0, data.Length);

            ms.Position = 0;
            ms.CopyTo(stream);
        }

        #endregion

        #region Methods

        /// <summary>
        /// 初始化
        /// </summary>
        private static void Init()
        {
            IObjectContainer container = ObjectContainer.Current;
            Assembly asm = Assembly.GetExecutingAssembly();

            // 搜索已加载程序集里面的消息类型
            foreach (Type item in AssemblyX.FindAllPlugins(typeof(IRequest), true))
            {
                var msg = TypeX.CreateInstance(item) as IRequest;
                if (msg != null)
                {
                    container.Register(typeof(IRequest), item, null, msg.Function);
                }
            }

            foreach (Type item in AssemblyX.FindAllPlugins(typeof(IResponse), true))
            {
                var msg = TypeX.CreateInstance(item) as IResponse;
                if (msg != null)
                {
                    container.Register(typeof(IResponse), item, null, msg.Function);
                }
            }
        }

        /// <summary>
        /// The set.
        /// </summary>
        /// <param name="rw">
        /// The rw.
        /// </param>
        private static void Set(IReaderWriter rw)
        {
            ReaderWriterSetting setting = rw.Settings;

            rw.Settings.Encoding = Encoding.Default;
            // setting.IsBaseFirst = true;
            // setting.EncodeInt = true;
            setting.UseObjRef = false;
            // setting.UseTypeFullName = false;
            // SetDebug(rw);
        }

        /// <summary>
        /// The set debug.
        /// </summary>
        /// <param name="rw">
        /// The rw.
        /// </param>
        [Conditional("DEBUG")]
        private static void SetDebug(IReaderWriter rw)
        {
            rw.Debug = true;
            rw.EnableTraceStream();
        }

        #endregion
    }
}