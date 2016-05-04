

import java.util.ArrayList;
import java.util.Collections;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
 
 
public class ListOfProducts {
 
    public static void main(String[] args) {
 
        BufferedReader br = null;
        BufferedWriter bw = null;
        ArrayList<Products> products = new ArrayList<Products>();
 
        try {
 
            String currentLine;
 
            br = new BufferedReader(new FileReader("Input_products.txt"));
 
            while ((currentLine = br.readLine()) != null) {
                               
                String[] splitLine = currentLine.split(" ");
                               
                products.add(new Products(splitLine[0], Double.parseDouble(splitLine[1])));
 
            }
            Collections.sort(products);
                       
            bw = new BufferedWriter(new FileWriter("Output_products.txt"));

            for(Products product : products) {
                bw.write(product.getProduct() + " " + (double) product.getPrice() + "\r\n");
            }
           
            bw.close();
        } 
        catch (Exception e) {
            System.out.println("Error!" + e);
        } 
        finally {
            try {
                if (br != null) {
                    br.close();
                }
            } 
            catch (IOException ex) {
                ex.printStackTrace();
            }
        }
    }
}

