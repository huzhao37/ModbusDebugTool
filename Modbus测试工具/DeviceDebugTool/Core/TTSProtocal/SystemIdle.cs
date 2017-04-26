// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SystemIdle.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary>
//   The system idle.  create version by chenqi
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace DeviceDebugTool.Core.TTSProtocal
{
    using NewLife.Model;

    /// <summary>
    /// The system idle.
    /// </summary>
    public class SystemIdle : TtsEntity, IResponse
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="SystemIdle"/> class.
        /// </summary>
        static SystemIdle()
        {
            ObjectContainer.Current.Register<IResponse, SystemIdle>(TtsFunction.SystemIdle);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemIdle"/> class.
        /// </summary>
        public SystemIdle()
        {
            this.Function = TtsFunction.SystemIdle;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The calculate extend data.
        /// </summary>
        public override void CalculateExtendData()
        {
            // base.CalculateExtendData();
        }

        /// <summary>
        /// The set args.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public override void SetArgs(object[] args)
        {
            base.SetArgs(args);
        }

        #endregion
    }
}