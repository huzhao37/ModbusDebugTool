// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpeechSynthesisFailResponse.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary>
//   The speech synthesis fail response.  create version by chenqi
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DeviceDebugTool.Core.TTSProtocal
{
    using System;
    using NewLife.Model;

    /// <summary>
    /// The speech synthesis fail response.
    /// </summary>
    public class SpeechSynthesisFailResponse : TtsEntity, IResponse
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="SpeechSynthesisFailResponse"/> class.
        /// </summary>
        static SpeechSynthesisFailResponse()
        {
            ObjectContainer.Current.Register<IResponse, SpeechSynthesisFailResponse>(
                TtsFunction.SpeechSynthesisFailResponse);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechSynthesisFailResponse"/> class.
        /// </summary>
        public SpeechSynthesisFailResponse()
        {
            this.Function = TtsFunction.SpeechSynthesisFailResponse;
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