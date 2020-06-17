public class AlgumNomeAqui {
    public String verifyWord(String wordChosen, Scanner reader){
        boolean answeredCorrectly = false;
        int tries = 1;
        String wordChosen = random.nextInt();
        String answer = wordChosen;
        while (tries>0 && !answeredCorrectly) {
            answer = reader.nextInt();
            if (wordChosen == answeredCorrectly) {
                System.out.println("You got it right");
                answeredCorrectly = true;
            }
            else if (answered != wordChosen) {
                System.out.println("Wrong");
            }
        }
    }
}

//https://pt.stackoverflow.com/q/240649/101
