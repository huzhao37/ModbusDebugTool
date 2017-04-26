// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SystemView.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary>
//   The system view.  create version by chenqi
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DeviceDebugTool.Core.TTSProtocal
{
    using System;

    using NewLife.Model;

    /// <summary>
    /// The system view.
    /// </summary>
    public class SystemView : TtsEntity, IRequest
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="SystemView"/> class.
        /// </summary>
        static SystemView()
        {
            ObjectContainer.Current.Register<IRequest, SystemView>(TtsFunction.SystemView);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemView"/> class.
        /// </summary>
        public SystemView()
        {
            this.Function = TtsFunction.SystemView;
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