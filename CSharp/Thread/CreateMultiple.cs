var threads = new List<Thread>();
for (int i = 0; i < 30; i++) { 
   threads.Add(new Thread(MetodoVoid)); 
   threads[i].Start();
}

//https://pt.stackoverflow.com/q/117396/101
