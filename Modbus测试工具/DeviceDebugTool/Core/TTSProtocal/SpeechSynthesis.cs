// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpeechSynthesis.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary>
//   The speech synthesis.  create version by chenqi
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DeviceDebugTool.Core.TTSProtocal
{
    using System;
    using System.Collections.Generic;

    using NewLife.Model;

    /// <summary>
    /// The speech synthesis.
    /// </summary>
    public class SpeechSynthesis : TtsEntity, IRequest
    {
        #region Fields

        /// <summary>
        /// The _ data length.
        /// </summary>
        private ushort _DataLength;

        /// <summary>
        /// The _ data.
        /// </summary>
        [NonSerialized]
        private List<byte> _Data;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="SpeechSynthesis"/> class.
        /// </summary>
        static SpeechSynthesis()
        {
            ObjectContainer.Current.Register<IRequest, SpeechSynthesis>(TtsFunction.SpeechSynthesis);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechSynthesis"/> class.
        /// </summary>
        public SpeechSynthesis()
        {
            this.Function = TtsFunction.SpeechSynthesis;
            this._Data = new List<byte>();
        }

        #endregion

        #region Public Properties


        /// <summary>
        /// 数据长度
        /// </summary>
        public ushort DataLength
        {
            get
            {
                return this._DataLength;
            }

            set
            {
                this._DataLength = value;
            }
        }
        /// <summary>
        /// 待合成二进制文本
        /// </summary>
        public List<byte> Data
        {
            get
            {
                return this._Data;
            }

            set
            {
                this._Data = value;
                this.DataLength = (UInt16)(this._Data.Count + 1);
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The calculate extend data.
        /// </summary>
        public override void CalculateExtendData()
        {
            // base.CalculateExtendData();
            this.ExtendData.Clear();
            DataLength = Convert.ToUInt16(Data.Count + 2);
            Byte[] temp = BitConverter.GetBytes(DataLength);
            Array.Reverse(temp);
            this.ExtendData.AddRange(temp);
            this.ExtendData.Add((Byte)this.Function);
            this.ExtendData.Add(0x01);
            this.ExtendData.AddRange(this._Data);
        }

        /// <summary>
        /// The set args.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public override void SetArgs(object[] args)
        {
            // base.SetArgs(args);
            this._Data = new List<byte>(args[0] as Byte[]);
        }

        #endregion
    }
}