//auto generated, do not modify it

using System.Collections.Generic;
using Geek.Server.Core.Net.Messages;
using MessagePack;

namespace Geek.Server.Proto
{
	[MessagePackObject(true)]
	public class ReqComposePet : Geek.Server.Core.Net.Messages.Message
	{
		[IgnoreMember]
		public const int Sid = 225320501;

		[IgnoreMember]
		public const int MsgID = Sid;
		[IgnoreMember]
		public override int MsgId => MsgID;

        /// <summary>
        /// 碎片id
        /// </summary>
        public int FragmentId { get; set; }
	}
}
