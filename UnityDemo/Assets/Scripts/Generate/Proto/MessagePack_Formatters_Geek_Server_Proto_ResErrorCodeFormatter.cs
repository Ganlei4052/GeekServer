// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
#pragma warning disable CS1591 // document public APIs

#pragma warning disable SA1129 // Do not use default value type constructor
#pragma warning disable SA1309 // Field names should not begin with underscore
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters.Geek.Server.Proto
{
    public sealed class ResErrorCodeFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::Geek.Server.Proto.ResErrorCode>
    {
        // ErrCode
        private static global::System.ReadOnlySpan<byte> GetSpan_ErrCode() => new byte[1 + 7] { 167, 69, 114, 114, 67, 111, 100, 101 };
        // Desc
        private static global::System.ReadOnlySpan<byte> GetSpan_Desc() => new byte[1 + 4] { 164, 68, 101, 115, 99 };
        // UniId
        private static global::System.ReadOnlySpan<byte> GetSpan_UniId() => new byte[1 + 5] { 165, 85, 110, 105, 73, 100 };

        public void Serialize(ref global::MessagePack.MessagePackWriter writer, global::Geek.Server.Proto.ResErrorCode value, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (value is null)
            {
                writer.WriteNil();
                return;
            }

            var formatterResolver = options.Resolver;
            writer.WriteMapHeader(3);
            writer.WriteRaw(GetSpan_ErrCode());
            writer.Write(value.ErrCode);
            writer.WriteRaw(GetSpan_Desc());
            global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Serialize(ref writer, value.Desc, options);
            writer.WriteRaw(GetSpan_UniId());
            writer.Write(value.UniId);
        }

        public global::Geek.Server.Proto.ResErrorCode Deserialize(ref global::MessagePack.MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            options.Security.DepthStep(ref reader);
            var formatterResolver = options.Resolver;
            var length = reader.ReadMapHeader();
            var ____result = new global::Geek.Server.Proto.ResErrorCode();

            for (int i = 0; i < length; i++)
            {
                var stringKey = global::MessagePack.Internal.CodeGenHelpers.ReadStringSpan(ref reader);
                switch (stringKey.Length)
                {
                    default:
                    FAIL:
                      reader.Skip();
                      continue;
                    case 7:
                        if (global::MessagePack.Internal.AutomataKeyGen.GetKey(ref stringKey) != 28539401683497541UL) { goto FAIL; }

                        ____result.ErrCode = reader.ReadInt64();
                        continue;
                    case 4:
                        if (global::MessagePack.Internal.AutomataKeyGen.GetKey(ref stringKey) != 1668506948UL) { goto FAIL; }

                        ____result.Desc = global::MessagePack.FormatterResolverExtensions.GetFormatterWithVerify<string>(formatterResolver).Deserialize(ref reader, options);
                        continue;
                    case 5:
                        if (global::MessagePack.Internal.AutomataKeyGen.GetKey(ref stringKey) != 430728375893UL) { goto FAIL; }

                        ____result.UniId = reader.ReadInt32();
                        continue;

                }
            }

            reader.Depth--;
            return ____result;
        }
    }

}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1129 // Do not use default value type constructor
#pragma warning restore SA1309 // Field names should not begin with underscore
#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name
