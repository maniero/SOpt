return View(movies.Where(x => x.MovieName != null && (search == null || x.MovieName.StartsWith(search))).ToList());

//https://pt.stackoverflow.com/q/387176/101
