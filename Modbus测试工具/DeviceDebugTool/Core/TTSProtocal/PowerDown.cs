// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PowerDown.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary>
//   The power down.  create version by chenqi
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DeviceDebugTool.Core.TTSProtocal
{
    using System;

    using NewLife.Model;

    /// <summary>
    /// The power down.
    /// </summary>
    public class PowerDown : TtsEntity, IRequest
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="PowerDown"/> class.
        /// </summary>
        static PowerDown()
        {
            ObjectContainer.Current.Register<IRequest, PowerDown>(TtsFunction.PowerDown);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerDown"/> class.
        /// </summary>
        public PowerDown()
        {
            this.Function = TtsFunction.PowerDown;
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
            this.ExtendData.Add((Byte)this.Function);
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