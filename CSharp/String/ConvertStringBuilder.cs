using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

class Program {
	static void Main() {
		var p1 = new Post(DateTime.Now, "Travelling to New Zealand", "I'm going to visit this wonderful country!", 12);
		p1.AddComment(new Comment("Have a nice trip!"));
		p1.AddComment(new Comment("Wow that's awesome!"));
		var p2 = new Post(DateTime.Now, "Good night guys",	"See you tomorrow", 5);
		p2.AddComment(new Comment("Good night"));
		p2.AddComment(new Comment("May the force be with you"));
		WriteLine(p1);
		WriteLine(p2);
	}
}

class Comment {
	public string Text { get; set; }
	public Comment() {}
	public Comment(string text) => Text = text;
}
class Post {
	public DateTime Moment { get; set; }
	public string Title { get; set; }
	public string Content { get; set; }
	public int Likes { get; set; }
	public List<Comment> Comments { get; set; } = new List<Comment>();
	public Post() {}
	public Post(DateTime moment, string title, string content, int likes) {
		Moment = moment;
		Title = title;
		Content = content;
		Likes = likes;
	}
	public void AddComment(Comment comment) => Comments.Add(comment);
	public void RemoveComment(Comment comment) => Comments.Remove(comment);
	public override string ToString() {
		var sb = new StringBuilder();
		sb.AppendLine(Title);
		sb.Append(Likes);
		sb.Append(" Likes - ");
		sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
		sb.AppendLine(Content);
		sb.AppendLine("Comments:");
		foreach (Comment c in Comments)	sb.AppendLine(c.Text);
		return sb.ToString();
	}
}

//https://pt.stackoverflow.com/q/417809/101
