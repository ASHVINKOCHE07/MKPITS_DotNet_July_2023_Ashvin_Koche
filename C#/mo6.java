public class Student {
    private int rno;
    private String name;
    private String course;
    private double fees;

    public Student() {
        // default constructor
    }

    public Student(int rno, String name, String course, double fees) {
        this.rno = rno;
        this.name = name;
        this.course = course;
        this.fees = fees;
    }

    public Student(int rno, String name, String course) {
        this.rno = rno;
        this.name = name;
        this.course = course;
    }

    public Student(int rno, String name) {
        this.rno = rno;
        this.name = name;
    }

    public void getdata() {
        // method to get data for student
    }

    public void getdata(int rno, String name) {
        this.rno = rno;
        this.name = name;
    }

    public void getdata(int rno, String name, String course) {
        this.rno = rno;
        this.name = name;
        this.course = course;
    }

    public void getdata(int rno, String name, String course, double fees) {
        this.rno = rno;
        this.name = name;
        this.course = course;
        this.fees = fees;
    }

    public void display() {
        System.out.println("Roll No: " + rno);
        System.out.println("Name: " + name);
        System.out.println("Course: " + course);
        System.out.println("Fees: " + fees);
    }
}