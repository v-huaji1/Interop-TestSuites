namespace Microsoft.Protocols.TestSuites.Common
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// RopGetStoreState request buffer structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RopGetStoreStateRequest : ISerializable
    {
        /// <summary>
        /// This value specifies the type of remote operation. For this operation, this field is set to 0x7B.
        /// </summary>
        public byte RopId;

        /// <summary>
        /// This value specifies the logon associated with this operation.
        /// </summary>
        public byte LogonId;

        /// <summary>
        /// This index specifies the location in the Server Object Handle Table where the handle for the input Server Object is stored.
        /// </summary>
        public byte InputHandleIndex;

        /// <summary>
        /// Serialize the ROP request buffer.
        /// </summary>
        /// <returns>The ROP request buffer serialized.</returns>
        public byte[] Serialize()
        {
            byte[] serializeBuffer = new byte[Marshal.SizeOf(this)];
            IntPtr requestBuffer = new IntPtr();
            requestBuffer = Marshal.AllocHGlobal(Marshal.SizeOf(this));
            try
            {
                Marshal.StructureToPtr(this, requestBuffer, true);
                Marshal.Copy(requestBuffer, serializeBuffer, 0, Marshal.SizeOf(this));
                return serializeBuffer;
            }
            finally
            {
                Marshal.FreeHGlobal(requestBuffer);
            }
        }

        /// <summary>
        /// Return the size of this structure.
        /// </summary>
        /// <returns>The size of this structure.</returns>
        public int Size()
        {
            return Marshal.SizeOf(this);
        }
    }

    /// <summary>
    /// RopGetStoreState response buffer structure.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct RopGetStoreStateResponse : IDeserializable
    {
        /// <summary>
        /// This value specifies the type of remote operation. For this operation, this field is set to 0x7B.
        /// </summary>
        public byte RopId;

        /// <summary>
        /// This index MUST be set to the InputHandleIndex specified in the request.
        /// </summary>
        public byte InputHandleIndex;

        /// <summary>
        /// This value specifies the status of the remote operation. For this response, this field is set to 0x00000000.
        /// </summary>
        public uint ReturnValue;

        /// <summary>
        /// The possible values are specified in [MS-OXCSTOR]. These flags specify the state related to the logged on user.
        /// </summary>
        public uint StoreState;

        /// <summary>
        /// Deserialize the ROP response buffer.
        /// </summary>
        /// <param name="ropBytes">ROPs bytes in response.</param>
        /// <param name="startIndex">The start index of this ROP.</param>
        /// <returns>The size of response buffer structure.</returns>
        public int Deserialize(byte[] ropBytes, int startIndex)
        {
            int index = startIndex;
            this.RopId = ropBytes[index++];
            this.InputHandleIndex = ropBytes[index++];
            this.ReturnValue = (uint)BitConverter.ToInt32(ropBytes, index);
            index += sizeof(uint);

            // Only success response has below fields
            if (this.ReturnValue == 0)
            {
                this.StoreState = (uint)BitConverter.ToInt32(ropBytes, index);
                index += sizeof(uint);
            }

            return index - startIndex;
        }
    }    
}