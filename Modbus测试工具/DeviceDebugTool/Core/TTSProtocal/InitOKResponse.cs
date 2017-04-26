// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InitOKResponse.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary>
//   The init ok response. create version by chenqi
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DeviceDebugTool.Core.TTSProtocal
{
    using System;
    using NewLife.Model;

    /// <summary>
    /// The init ok response.
    /// </summary>
    public class InitOKResponse : TtsEntity, IResponse
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="InitOKResponse"/> class.
        /// </summary>
        static InitOKResponse()
        {
            ObjectContainer.Current.Register<IResponse, InitOKResponse>(TtsFunction.InitOKResponse);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitOKResponse"/> class.
        /// </summary>
        public InitOKResponse()
        {
            this.Function = TtsFunction.InitOKResponse;
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