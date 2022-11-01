package hw05p1;

public class Statistics {
    private int FieldGoalsMade;
    private int FreeThrowsMade;
    private int ThreePointersMade;
    private int FieldGoalAttempts;
    private int FreeThrowAttempts;
    private int ThreePointAttempts;

    //SETTERS
    public void setFieldGoalsMade(int fieldGoalsMade) {
        FieldGoalsMade = fieldGoalsMade;
    }

    public void setFreeThrowsMade(int freeThrowsMade) {
        FreeThrowsMade = freeThrowsMade;
    }

    public void set3PointersMade(int threePointersMade) {
        ThreePointersMade = threePointersMade;
    }

    public void setFieldGoalAttempts(int fieldGoalAttempts) {
        FieldGoalAttempts = fieldGoalAttempts;
    }

    public void setFreeThrowAttempts(int freeThrowAttempts) {
        FreeThrowAttempts = freeThrowAttempts;
    }

    public void set3PointAttempts(int threePointAttempts) {
        ThreePointAttempts = threePointAttempts;
    }

    //GETTERS
    public double getFieldGoalPercent() {
        return ((double) this.FieldGoalsMade * 100 / this.FieldGoalAttempts);
    }

    public double getFreeThrowPercent() {
        return  ((double) this.FreeThrowsMade * 100 / this.FreeThrowAttempts) ;
    }

    public int getTotalPoints() {
        return 2 * this.FieldGoalsMade + this.FreeThrowsMade + 3* this.ThreePointersMade;
    }

    public double get3PointPercent() {
        return  ((double) this.ThreePointersMade * 100 / this.ThreePointAttempts) ;

    }
}
