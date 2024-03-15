package baitapjava2;
import java.net.*;
import java.net.InetAddress;

public class local {
      public static void main(String[] args) {
    try {
      InetAddress me = InetAddress.getLocalHost();
      System.out.println("My name is " + me.getHostName());
      System.out.println("My address is " + me.getHostAddress());
      byte[] address = me.getAddress();
      for (int i = 0; i < address.length; i++) {
        System.out.print(address[i] + " ");
      }
      System.out.println();
    }
    catch (UnknownHostException e) {
      System.err.println("Could not determine local address.");
      System.err.println("Perhaps the network is down?");
    }
  }
}
