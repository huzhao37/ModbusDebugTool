// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PauseSpeechSynthesis.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary>
//   The pause speech synthesis.  create version by chenqi
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DeviceDebugTool.Core.TTSProtocal
{
    using System;

    using NewLife.Model;

    /// <summary>
    /// The pause speech synthesis.
    /// </summary>
    public class PauseSpeechSynthesis : TtsEntity, IRequest
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes static members of the <see cref="PauseSpeechSynthesis"/> class.
        /// </summary>
        static PauseSpeechSynthesis()
        {
            ObjectContainer.Current.Register<IRequest, PauseSpeechSynthesis>(TtsFunction.PauseSpeechSynthesis);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PauseSpeechSynthesis"/> class.
        /// </summary>
        public PauseSpeechSynthesis()
        {
            this.Function = TtsFunction.PauseSpeechSynthesis;
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