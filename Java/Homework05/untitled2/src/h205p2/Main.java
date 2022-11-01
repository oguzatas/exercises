package h205p2;

import java.text.DecimalFormat;

public class Main {
    public static void main(String[] args)
    {
        DecimalFormat df = new DecimalFormat("0.00");
        Movie lotr = new Movie();
        Movie godfather = new Movie();
        //Inıtializing
        //movie01
        lotr.addRating(5);
        lotr.addRating(5);
        lotr.addRating(5);
        lotr.addRating(5);
        lotr.addRating(5);
        lotr.addRating(4);
        lotr.setMovieName("The Lord Of The Rings");
        lotr.setMPAARatingAsPGThirteen();

        //movie02
        godfather.addRating(5);
        godfather.addRating(5);
        godfather.addRating(5);
        godfather.addRating(5);
        godfather.addRating(5);
        godfather.addRating(5);
        godfather.addRating(5);
        godfather.addRating(3);
        godfather.setMovieName("The Godfather");
        godfather.setMPAARatingAsR();

        System.out.println("The movie"+ godfather.getMovieName() +"'s average rating is "+
                df.format(godfather.getAverage()));

        System.out.println("The movie"+ lotr.getMovieName()+"'s average rating is "+
                df.format(lotr.getAverage()));

    }
        }
