﻿using MessagePack;

namespace Geek.Server.Core.Net.Messages
{
    public abstract class Message
    {
        /// <summary>
        /// 消息唯一id
        /// </summary>
        public int UniId { get; set; }
        [IgnoreMember]
        public virtual int MsgId { get; }
    }
}
