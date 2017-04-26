// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SystemBusy.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary>
//   The system busy.  create version by chenqi
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DeviceDebugTool.Core.TTSProtocal
{
    using System;
    using NewLife.Model;

    /// <summary>
    /// The system busy.
    /// </summary>
    public class SystemBusy : TtsEntity, IResponse
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="SystemBusy"/> class.
        /// </summary>
        static SystemBusy()
        {
            ObjectContainer.Current.Register<IResponse, SystemBusy>(TtsFunction.SystemBusy);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemBusy"/> class.
        /// </summary>
        public SystemBusy()
        {
            this.Function = TtsFunction.SystemBusy;
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