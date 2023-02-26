using System;

public class WritingAssignment : Assignment
{
    private string topicDetails;

    public WritingAssignment(string studentName, string topic, string topicDetails)
        : base(studentName, topic)
    {
        this.topicDetails = topicDetails;
    }

    public string GetWritingInformation()
    {
        string studentName = base.GetStudentName();
        return $"{topicDetails} by {studentName}";
    }
}
