using static System.Console;
using Kitty.Core.Blocks;
					
public class Program {
	public static void Main() {
		var bloco1 = new Block<string>("título", "conteúdo");
		var bloco2 = new Block<string>("título2", "conteúdo2");
		WriteLine(bloco1.Equals(bloco2));
		WriteLine(bloco1.Equals(bloco1));
	}
}

namespace Kitty.Core.Blocks {
    class Block<T> {
        public string Title { get; private set; }
        public T Contents { get; private set; }

        public Block(string title, T contents) {
            this.Title = title;
            this.Contents = contents;
        }

        public override bool Equals(object obj) {
            Block<T> other = obj as Block<T>;
			if (other == null) return false;
            return Title == other.Title;
        }
    }
}

//https://pt.stackoverflow.com/q/123930/101
