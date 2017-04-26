// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ResumeSpeechSynthesis.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary>
//   The resume speech synthesis.  create version by chenqi
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DeviceDebugTool.Core.TTSProtocal
{
    using System;

    using NewLife.Model;

    /// <summary>
    /// The resume speech synthesis.
    /// </summary>
    public class ResumeSpeechSynthesis : TtsEntity, IRequest
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="ResumeSpeechSynthesis"/> class.
        /// </summary>
        static ResumeSpeechSynthesis()
        {
            ObjectContainer.Current.Register<IRequest, ResumeSpeechSynthesis>(TtsFunction.ResumeSpeechSynthesis);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResumeSpeechSynthesis"/> class.
        /// </summary>
        public ResumeSpeechSynthesis()
        {
            this.Function = TtsFunction.ResumeSpeechSynthesis;
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