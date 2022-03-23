//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Angel
{
    [Serializable]
    public class ActivityDetectionMsg : Message
    {
        public const string k_RosMessageName = "angel_msgs/ActivityDetection";
        public override string RosMessageName => k_RosMessageName;

        // 
        //  An activity detection on a set of frames.
        // 
        //  Header frame_id should indicate the source these detections were predicted
        //  over.
        public Std.HeaderMsg header;
        //  Timestamps of the first image and the last image these predictions pertain to.
        public BuiltinInterfaces.TimeMsg source_stamp_start_frame;
        public BuiltinInterfaces.TimeMsg source_stamp_end_frame;
        //  Prediction classification label ordered from most confident to least.
        public string[] label_vec;

        public ActivityDetectionMsg()
        {
            this.header = new Std.HeaderMsg();
            this.source_stamp_start_frame = new BuiltinInterfaces.TimeMsg();
            this.source_stamp_end_frame = new BuiltinInterfaces.TimeMsg();
            this.label_vec = new string[0];
        }

        public ActivityDetectionMsg(Std.HeaderMsg header, BuiltinInterfaces.TimeMsg source_stamp_start_frame, BuiltinInterfaces.TimeMsg source_stamp_end_frame, string[] label_vec)
        {
            this.header = header;
            this.source_stamp_start_frame = source_stamp_start_frame;
            this.source_stamp_end_frame = source_stamp_end_frame;
            this.label_vec = label_vec;
        }

        public static ActivityDetectionMsg Deserialize(MessageDeserializer deserializer) => new ActivityDetectionMsg(deserializer);

        private ActivityDetectionMsg(MessageDeserializer deserializer)
        {
            this.header = Std.HeaderMsg.Deserialize(deserializer);
            this.source_stamp_start_frame = BuiltinInterfaces.TimeMsg.Deserialize(deserializer);
            this.source_stamp_end_frame = BuiltinInterfaces.TimeMsg.Deserialize(deserializer);
            deserializer.Read(out this.label_vec, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.source_stamp_start_frame);
            serializer.Write(this.source_stamp_end_frame);
            serializer.WriteLength(this.label_vec);
            serializer.Write(this.label_vec);
        }

        public override string ToString()
        {
            return "ActivityDetectionMsg: " +
            "\nheader: " + header.ToString() +
            "\nsource_stamp_start_frame: " + source_stamp_start_frame.ToString() +
            "\nsource_stamp_end_frame: " + source_stamp_end_frame.ToString() +
            "\nlabel_vec: " + System.String.Join(", ", label_vec.ToList());
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
