namespace Microsoft.Protocols.TestSuites.MS_OXCSTOR
{
    using System.Collections.Generic;
    using Microsoft.Protocols.TestSuites.Common;

    /// <summary>
    /// ROP Output Buffer structure specified in MS-OXCROPS section 2.2 Message Syntax
    /// </summary>
    public struct RopOutputBuffer
    {
        /// <summary>
        /// Array of ROP buffers. For an ROP input buffer, this field contains an array of ROP request 
        /// buffers. For an ROP output buffer, this field contains an array of ROP response buffers. The 
        /// format of each ROP buffer is specified in subsequent sections. The size of this field is 2 
        /// bytes less than the value specified in the RopSize field.
        /// </summary>
        public List<IDeserializable> RopsList;

        /// <summary>
        /// Array of 32-bit values. Each 32-bit value specifies a Server object handle that is referenced 
        /// by an ROP buffer. The size of this field is equal to the number of bytes of data remaining 
        /// in the ROP input/output buffer after the RopsList field.
        /// </summary>
        public List<uint> ServerObjectHandleTable;
    }
}