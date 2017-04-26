// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpeechSynthesisOKResponse.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary> 
//   The speech synthesis ok response.  create version by chenqi
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DeviceDebugTool.Core.TTSProtocal
{
    using System;
    using NewLife.Model;

    /// <summary>
    /// The speech synthesis ok response.
    /// </summary>
    public class SpeechSynthesisOKResponse : TtsEntity, IResponse
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="SpeechSynthesisOKResponse"/> class.
        /// </summary>
        static SpeechSynthesisOKResponse()
        {
            ObjectContainer.Current.Register<IResponse, SpeechSynthesisOKResponse>(
                TtsFunction.SpeechSynthesisOKResponse);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechSynthesisOKResponse"/> class.
        /// </summary>
        public SpeechSynthesisOKResponse()
        {
            this.Function = TtsFunction.SpeechSynthesisOKResponse;
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
        public override void SetArgs(params object[] args)
        {
            base.SetArgs(args);
        }

        #endregion
    }
}