﻿using ProtoBuf;
using Pulsar.Common.Messages.other;

namespace Pulsar.Common.Messages.Administration.RegistryEditor
{
    [ProtoContract]
    public class DoLoadRegistryKey : IMessage
    {
        [ProtoMember(1)]
        public string RootKeyName { get; set; }
    }
}
