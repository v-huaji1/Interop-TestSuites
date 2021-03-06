﻿namespace Microsoft.Protocols.TestSuites.MS_ONESTORE
{
    using Common;
    using System.Collections.Generic;

    /// <summary>
    /// This class is used to represent a JCID
    /// </summary>
    public class JCID
    {
        /// <summary>
        /// Gets or sets an unsigned integer that specifies the type of object
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// Gets or sets the IsBinary value that specifies whether the object contains encryption data transmitted over the File Synchronization via SOAP over HTTP Protocol.
        /// </summary>
        public int IsBinary { get; set; }
        /// <summary>
        /// Gets or sets the IsPropertySet value that specifies whether the object contains a property set. 
        /// </summary>
        public int IsPropertySet { get; set; }

        /// <summary>
        /// Gets or sets a value of IsGraphNode field.
        /// </summary>
        public int IsGraphNode { get; set; }
        /// <summary>
        /// Gets or sets the IsFileData value that specifies whether the object is a file data object.
        /// </summary>
        public int IsFileData { get; set; }
        /// <summary>
        /// Gets or sets the IsReadOnly value that specifies whether the object's data MUST NOT be changed when the object is revised.
        /// </summary>
        public int IsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the value of Reserved field.
        /// </summary>
        public int Reserved { get; set; }

        /// <summary>
        /// This method is used to convert the element of JCID object into a byte List.
        /// </summary>
        /// <returns>Return the byte list which store the byte information of JCID</returns>
        public List<byte> SerializeToByteList()
        {
            BitWriter bitWriter = new BitWriter(4);
            bitWriter.AppendInit32(this.Index, 16);
            bitWriter.AppendInit32(this.IsBinary, 1);
            bitWriter.AppendInit32(this.IsPropertySet, 1);
            bitWriter.AppendInit32(this.IsGraphNode, 1);
            bitWriter.AppendInit32(this.IsFileData, 1);
            bitWriter.AppendInit32(this.IsReadOnly, 1);
            bitWriter.AppendInit32(this.Reserved, 11);

            return new List<byte>(bitWriter.Bytes);
        }
        /// <summary>
        /// This method is used to deserialize the JCID object from the specified byte array and start index.
        /// </summary>
        /// <param name="byteArray">Specify the byte array.</param>
        /// <param name="startIndex">Specify the start index from the byte array.</param>
        /// <returns>Return the length in byte of the JCID object.</returns>
        public int DoDeserializeFromByteArray(byte[] byteArray,int startIndex)
        {
            using (BitReader bitReader = new BitReader(byteArray, startIndex))
            {
                this.Index = bitReader.ReadInt32(16);
                this.IsBinary = bitReader.ReadInt32(1);
                this.IsPropertySet = bitReader.ReadInt32(1);
                this.IsGraphNode = bitReader.ReadInt32(1);
                this.IsFileData = bitReader.ReadInt32(1);
                this.IsReadOnly = bitReader.ReadInt32(1);
                this.Reserved = bitReader.ReadInt32(11);

                return 4;
            }
        }
    }
}
