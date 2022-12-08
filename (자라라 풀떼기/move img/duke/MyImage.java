/*
image��  sound
image
1.Applet - getImage(��ġ, ���ϸ�)�޼ҵ�
2.Frame - Toolkit ��ü���.

sound
	1.Applet - getAudioClip(��ġ, ���ϸ�)�޼ҵ�
	2.Frame - import javax.sound.midi.*; �ҷ����� ��.
 
*/
import java.awt.*;
import java.awt.event.*;
import java.applet.*;

public class MyImage extends Applet implements Runnable, ActionListener{
	private Button btnStart = new Button("start");
	private Button btnStop = new Button("stop");
	private Panel pnl = new Panel();
	
	private Image img = null;
	private AudioClip au = null;
	private boolean flag = false;
	
	public void init(){
		this.setLayout(new BorderLayout());
		
		pnl.add(btnStart);
		pnl.add(btnStop);
	
		img = this.getImage(getDocumentBase(), "duke/T1.gif");
		au = this.getAudioClip(getDocumentBase(), "audio/sound.au");
		
		this.add(pnl, "North");
		
	}
	public void start(){
		this.btnStart.addActionListener(this);
		this.btnStop.addActionListener(this);
	}
	public void paint(Graphics g){
		g.drawImage(this.img, 50, 50, 100, 100, this);
	}
	
	public void run(){
		int i = 1;
		while(this.flag){
			if(i == 10){
				i=1;
			}
			i = i+1;
			this.img=this.getImage(getDocumentBase(), "duke/T"+ i +".gif");
			repaint();
			try{
				Thread.sleep(100);
			}catch(Exception e){}
		}
	}
	public void actionPerformed(ActionEvent e){
		Object o = e.getSource();
		Thread t = new Thread(MyImage.this);
		t.start();
		if(o==btnStart){
			
			this.flag=true;
			au.play();
			
		}else if(o==btnStop){
			this.flag=false;
			au.stop();
		}
	}
	
}
