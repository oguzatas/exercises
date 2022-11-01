/**

 Program description: hw04 p1

 Author:Oguzhan Atas

 E-mail address: oguzhanatas37@gmail.com

 Homework Number: 04

 Last Changed:

 */

package homework04;
import java.util.Scanner;

public class Homework04 {




    public  void main(String[] args) {

        Scanner s = new Scanner(System.in);
        hangman h = new hangman();


        //set secret word
        System.out.println("Please enter your secret word");
        String sWord = s.nextLine();
        h.setSecretWord(sWord);
        h.setDisguisedWord();
        h.getDisguisedWord();

        //make guess section

        //checking with isfound

        //
    }

    public class hangman {

        private  String secretWord;
        private  String disguisedWord;
        private int numberOfGuesses;
        private int numberOfIncorrectGuesses;

        public void setSecretWord(String secretWord) {
            this.secretWord = secretWord;
        }

        public String getDisguisedWord() {
            return disguisedWord;
        }

        public void setDisguisedWord() {

            int x = this.secretWord.length();
            String e = "";
            for(int y=0 ; y<x ; y++)
            {
                e = e + "?";
            }

            e = this.disguisedWord;




        }

        public void makeGuess(char c)
        {

        }

        public String getSecretWord() {
            return secretWord;
        }

        public int getNumberOfGuesses() {
            return numberOfGuesses;
        }

        public int getNumberOfIncorrectGuesses() {
            return numberOfIncorrectGuesses;
        }

        public boolean isFound()
        {
            return true;
        }

    }




}
