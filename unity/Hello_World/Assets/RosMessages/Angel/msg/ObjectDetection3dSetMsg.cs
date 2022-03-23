//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Angel
{
    [Serializable]
    public class ObjectDetection3dSetMsg : Message
    {
        public const string k_RosMessageName = "angel_msgs/ObjectDetection3dSet";
        public override string RosMessageName => k_RosMessageName;

        // 
        //  A collection of 3D object detections obtained by projecting the 2D detections
        //  onto the world scene.
        // 
        //  Box [left,right,top,bottom] origin is coordinate is the upper-left of the
        //  source image.
        // 
        //  Header frame_id should indicate the source these detections were predicted
        //  over.
        public Std.HeaderMsg header;
        //  Timestamp of the source image these predictions pertain to.
        public BuiltinInterfaces.TimeMsg source_stamp;
        //  Vector of object labels with length = num_objects
        public string[] object_labels;
        //  Number of objects contained in this set.
        public long num_objects;
        //  Vector of detection axis aligned bounding box bounds point coordinates.
        //  Each vector here should be of congruent length, where value `i` corresponds
        //  to the 3D coordinate for detection `i`.
        public Geometry.PointMsg[] left;
        public Geometry.PointMsg[] right;
        public Geometry.PointMsg[] top;
        public Geometry.PointMsg[] bottom;

        public ObjectDetection3dSetMsg()
        {
            this.header = new Std.HeaderMsg();
            this.source_stamp = new BuiltinInterfaces.TimeMsg();
            this.object_labels = new string[0];
            this.num_objects = 0;
            this.left = new Geometry.PointMsg[0];
            this.right = new Geometry.PointMsg[0];
            this.top = new Geometry.PointMsg[0];
            this.bottom = new Geometry.PointMsg[0];
        }

        public ObjectDetection3dSetMsg(Std.HeaderMsg header, BuiltinInterfaces.TimeMsg source_stamp, string[] object_labels, long num_objects, Geometry.PointMsg[] left, Geometry.PointMsg[] right, Geometry.PointMsg[] top, Geometry.PointMsg[] bottom)
        {
            this.header = header;
            this.source_stamp = source_stamp;
            this.object_labels = object_labels;
            this.num_objects = num_objects;
            this.left = left;
            this.right = right;
            this.top = top;
            this.bottom = bottom;
        }

        public static ObjectDetection3dSetMsg Deserialize(MessageDeserializer deserializer) => new ObjectDetection3dSetMsg(deserializer);

        private ObjectDetection3dSetMsg(MessageDeserializer deserializer)
        {
            this.header = Std.HeaderMsg.Deserialize(deserializer);
            this.source_stamp = BuiltinInterfaces.TimeMsg.Deserialize(deserializer);
            deserializer.Read(out this.object_labels, deserializer.ReadLength());
            deserializer.Read(out this.num_objects);
            deserializer.Read(out this.left, Geometry.PointMsg.Deserialize, deserializer.ReadLength());
            deserializer.Read(out this.right, Geometry.PointMsg.Deserialize, deserializer.ReadLength());
            deserializer.Read(out this.top, Geometry.PointMsg.Deserialize, deserializer.ReadLength());
            deserializer.Read(out this.bottom, Geometry.PointMsg.Deserialize, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.source_stamp);
            serializer.WriteLength(this.object_labels);
            serializer.Write(this.object_labels);
            serializer.Write(this.num_objects);
            serializer.WriteLength(this.left);
            serializer.Write(this.left);
            serializer.WriteLength(this.right);
            serializer.Write(this.right);
            serializer.WriteLength(this.top);
            serializer.Write(this.top);
            serializer.WriteLength(this.bottom);
            serializer.Write(this.bottom);
        }

        public override string ToString()
        {
            return "ObjectDetection3dSetMsg: " +
            "\nheader: " + header.ToString() +
            "\nsource_stamp: " + source_stamp.ToString() +
            "\nobject_labels: " + System.String.Join(", ", object_labels.ToList()) +
            "\nnum_objects: " + num_objects.ToString() +
            "\nleft: " + System.String.Join(", ", left.ToList()) +
            "\nright: " + System.String.Join(", ", right.ToList()) +
            "\ntop: " + System.String.Join(", ", top.ToList()) +
            "\nbottom: " + System.String.Join(", ", bottom.ToList());
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
