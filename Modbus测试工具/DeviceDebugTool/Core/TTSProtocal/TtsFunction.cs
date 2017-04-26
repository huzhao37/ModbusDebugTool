﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TtsFunction.cs" company="南京瀚之显电子科技有限公司">
//   
// </copyright>
// <summary>
//   The tts function.  create version by chenqi
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DeviceDebugTool.Core.TTSProtocal
{
    /// <summary>
    /// The tts function.
    /// </summary>
    public enum TtsFunction : byte
    {
        #region Request

        /// <summary>
        /// 语音合成命令
        /// </summary>
        SpeechSynthesis = 0x01, 

        /// <summary>
        /// 停止语音合成
        /// </summary>
        SpeechSynthesisStop, 

        /// <summary>
        /// 暂停合成命令
        /// </summary>
        PauseSpeechSynthesis, 

        /// <summary>
        /// 恢复合成命令
        /// </summary>
        ResumeSpeechSynthesis, 

        /// <summary>
        /// TTS系统状态查询命令
        /// </summary>
        SystemView = 0x21, 

        /// <summary>
        /// 系统进入PowerDown模式，Reset之后恢复
        /// </summary>
        PowerDown = 0x88, 

        #endregion

        #region Response

        /// <summary>
        /// 语音合成成功
        /// </summary>
        SpeechSynthesisOKResponse = 0x41, 

        /// <summary>
        /// 系统初始化成功
        /// </summary>
        InitOKResponse = 0x4A, 

        /// <summary>
        /// 收到错误帧
        /// </summary>
        SpeechSynthesisFailResponse = 0x45, 

        /// <summary>
        /// 系统忙碌
        /// </summary>
        SystemBusy = 0x4E, 

        /// <summary>
        /// 系统空闲
        /// </summary>
        SystemIdle = 0x4F, 

        #endregion
    }
}