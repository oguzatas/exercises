package myProject;
import javax.swing.*;  
public class main {  
public static void main(String[] args) {  
JFrame f=new JFrame();//creating instance of JFrame  
JTextField tb= new JTextField();
JTextField tb2= new JTextField();
JButton b=new JButton("LogIn");//creating instance of JButton 
JLabel l1=new JLabel("Isim");
JLabel l2=new JLabel("Soy Isim");  


l1.setBounds(20,50,100,30);
l2.setBounds(20, 100, 100, 30);
b.setBounds(100,150,100, 40);//x axis, y axis, width, height  
tb.setBounds(100,50, 150,30); 
tb2.setBounds(100,100, 150,30);

f.add(b);//adding button in JFrame  
f.add(tb);
f.add(tb2);
f.add(l1);
f.add(l2);

b.addActionListener(null);
          
f.setSize(350,300);//width and height  
f.setLayout(null);//using no layout managers  
f.setVisible(true);//making the frame visible  
}  
}  