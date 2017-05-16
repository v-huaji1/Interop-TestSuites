namespace Microsoft.Protocols.TestSuites.MS_OXORULE
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Action Data buffer format for ActionType: OP_REPLY, OP_OOF_REPLY
    /// </summary>
    public class ReplyActionData : IActionData
    {
        /// <summary>
        /// ReplyTemplate FID which obtained from a Message Template
        /// </summary>
        private ulong replyTemplateFID;

        /// <summary>
        /// ReplyTemplate MID which obtained from a Message Template
        /// </summary>
        private ulong replyTemplateMID;

        /// <summary>
        /// The ReplyTemplateGUID field in the Reply ActionData buffer is the value of the GUID generated by the client in the process of creating a Reply template
        /// </summary>
        private byte[] replyTemplateGUID;

        /// <summary>
        /// Gets or sets ReplyTemplate FID which obtained from a Message Template
        /// </summary>
        public ulong ReplyTemplateFID
        {
            get { return this.replyTemplateFID; }
            set { this.replyTemplateFID = value; }
        }

        /// <summary>
        /// Gets or sets the ReplyTemplate MID which obtained from a Message Template
        /// </summary>
        public ulong ReplyTemplateMID
        {
            get { return this.replyTemplateMID; }
            set { this.replyTemplateMID = value; }
        }

        /// <summary>
        /// Gets or sets the ReplyTemplateGUID
        /// </summary>
        public byte[] ReplyTemplateGUID
        {
            get { return this.replyTemplateGUID; }
            set { this.replyTemplateGUID = value; }
        }

        /// <summary>
        /// The total Size of this ActionData buffer
        /// </summary>
        /// <returns>Number of bytes in this ActionData buffer.</returns>
        public int Size()
        {
            return this.Serialize().Length;
        }

        /// <summary>
        /// Get serialized byte array for this ActionData
        /// </summary>
        /// <returns>Serialized byte array.</returns>
        public byte[] Serialize()
        {
            List<byte> result = new List<byte>();
            result.AddRange(BitConverter.GetBytes(this.ReplyTemplateFID));
            result.AddRange(BitConverter.GetBytes(this.ReplyTemplateMID));
            result.AddRange(this.ReplyTemplateGUID);

            return result.ToArray();
        }

        /// <summary>
        /// Deserialized byte array to a ReplyActionData instance
        /// </summary>
        /// <param name="buffer">Byte array contains data of an ActionData instance.</param>
        /// <returns>Bytes count that deserialized in buffer.</returns>
        public uint Deserialize(byte[] buffer)
        {
            int startIndex = 0;
            this.ReplyTemplateFID = BitConverter.ToUInt64(buffer, startIndex);
            startIndex += 8;
            this.ReplyTemplateMID = BitConverter.ToUInt64(buffer, startIndex);
            startIndex += 8;
            uint guidLength = (uint)Guid.NewGuid().ToByteArray().Length;
            byte[] arrayOfGuid = new byte[guidLength];
            Array.Copy(buffer, startIndex, arrayOfGuid, 0, guidLength);
            this.ReplyTemplateGUID = arrayOfGuid;
            startIndex += (int)guidLength;

            return (uint)startIndex;
        }
    }
}