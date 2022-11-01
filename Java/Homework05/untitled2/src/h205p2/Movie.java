package h205p2;

public class Movie {

    //Getters and Setters

    public String getMovieName() {
        return MovieName;
    }

    public void setMovieName(String movieName) {
        MovieName = movieName;
    }

    public String getMPAARating() {
        return MPAARating;
    }

    public void setMPAARatingAsG() {
        this.MPAARating = "G";
    }
    public void setMPAARatingAsPG() {
        this.MPAARating = "PG";
    }
    public void setMPAARatingAsPGThirteen() {
        this.MPAARating = "PG-13";
    }
    public void setMPAARatingAsR() {
        this.MPAARating = "R";
    }
    public void setMPAARatingAsNCSeventeen() {
        this.MPAARating = "NC-17";
    }


    // Attributes
    private String MovieName;
    private String MPAARating;
    private int RatedAsTerrible;
    private int RatedAsBad;
    private int RatedAsOk;
    private int RatedAsGood;
    private int RatedAsGreat;

    //Methods

    public int addRating(int rate) {
      if( rate == 1)
        {
            this.RatedAsTerrible++;
        }
      else if( rate == 2)
        {
            this.RatedAsBad++;
        }
      else if( rate == 3)
      {
            this.RatedAsOk++;
      }
      else if( rate == 4)
      {
            this.RatedAsGood++;
      }
      else if( rate == 5)
      {
            this.RatedAsGreat++;
      }
      else
      {
          throw new RuntimeException("Invalid input from user");
      }
      return rate;
    }

    public float getAverage() {
        return (float) (this.RatedAsTerrible + 2*this.RatedAsBad
                + 3*this.RatedAsOk + 4*this.RatedAsGood
                + 5*this.RatedAsGreat) / (this.RatedAsTerrible +
                this.RatedAsBad + this.RatedAsOk + this.RatedAsGood
                +this.RatedAsGreat);
    }


}
