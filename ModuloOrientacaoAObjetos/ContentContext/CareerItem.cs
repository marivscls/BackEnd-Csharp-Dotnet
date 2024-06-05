using ModuloOrientacaoAObjetos.SharedContext;

namespace ModuloOrientacaoAObjetos.ContentContext;

public class CareerItem : Base
{
    public CareerItem(
        int order,
        string title,
        string description,
        Course course)
    {
        if (course == null)
            AddNotification(new NotificationContext.Notification("Course", "Curso inválido"));

        Order = order;
        Title = title;
        Description = description;
        Course = course;
    }

    public int Order { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }
}

