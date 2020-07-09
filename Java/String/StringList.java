public class ScoreBoard implements Listener {
    @EventHandler
    public void pj(PlayerJoinEvent e) {
        /*tipo de retorno do getStringList*/ list = Main.getMensagens().getStringList("Scoreboard");
        for (int i = 0;  i < list.length; i++) {    
             Scoreboard scoreboard = Bukkit.getServer().getScoreboardManager().getNewScoreboard();
             Objective obj = scoreboard.registerNewObjective(Main.getMensagens().getString("Titulo"), "dummy");
             obj.setDisplaySlot(DisplaySlot.SIDEBAR);
             Score web = obj.getScore(list.get(i));
             web.setScore(i);
             Player p = e.getPlayer();
             p.setScoreboard(scoreboard);
        }
    }
}

//https://pt.stackoverflow.com/q/275081/101
