set { player = value.Where(x => !player.Any(y => x.NickName.Contains(y.NickName))).ToList(); }

//https://pt.stackoverflow.com/q/361525/101
