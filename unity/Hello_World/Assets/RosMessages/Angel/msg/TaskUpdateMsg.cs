//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Angel
{
    [Serializable]
    public class TaskUpdateMsg : Message
    {
        public const string k_RosMessageName = "angel_msgs/TaskUpdate";
        public override string RosMessageName => k_RosMessageName;

        // 
        //  Represents the current status of the task being performed.
        // 
        //  Standard ROS message header
        public Std.HeaderMsg header;
        //  Task name
        public string task_name;
        //  List of steps for this task
        public string[] steps;
        //  Current/previous steps
        public string current_step;
        public string previous_step;
        //  Current activity
        public string current_activity;
        public string next_activity;

        public TaskUpdateMsg()
        {
            this.header = new Std.HeaderMsg();
            this.task_name = "";
            this.steps = new string[0];
            this.current_step = "";
            this.previous_step = "";
            this.current_activity = "";
            this.next_activity = "";
        }

        public TaskUpdateMsg(Std.HeaderMsg header, string task_name, string[] steps, string current_step, string previous_step, string current_activity, string next_activity)
        {
            this.header = header;
            this.task_name = task_name;
            this.steps = steps;
            this.current_step = current_step;
            this.previous_step = previous_step;
            this.current_activity = current_activity;
            this.next_activity = next_activity;
        }

        public static TaskUpdateMsg Deserialize(MessageDeserializer deserializer) => new TaskUpdateMsg(deserializer);

        private TaskUpdateMsg(MessageDeserializer deserializer)
        {
            this.header = Std.HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.task_name);
            deserializer.Read(out this.steps, deserializer.ReadLength());
            deserializer.Read(out this.current_step);
            deserializer.Read(out this.previous_step);
            deserializer.Read(out this.current_activity);
            deserializer.Read(out this.next_activity);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.task_name);
            serializer.WriteLength(this.steps);
            serializer.Write(this.steps);
            serializer.Write(this.current_step);
            serializer.Write(this.previous_step);
            serializer.Write(this.current_activity);
            serializer.Write(this.next_activity);
        }

        public override string ToString()
        {
            return "TaskUpdateMsg: " +
            "\nheader: " + header.ToString() +
            "\ntask_name: " + task_name.ToString() +
            "\nsteps: " + System.String.Join(", ", steps.ToList()) +
            "\ncurrent_step: " + current_step.ToString() +
            "\nprevious_step: " + previous_step.ToString() +
            "\ncurrent_activity: " + current_activity.ToString() +
            "\nnext_activity: " + next_activity.ToString();
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
