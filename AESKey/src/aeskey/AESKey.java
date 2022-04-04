/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package aeskey;
import java.security.InvalidAlgorithmParameterException;
import java.security.InvalidKeyException;
import java.security.Key;
import java.security.KeyPair;
import java.security.KeyPairGenerator;
import java.security.NoSuchAlgorithmException;
import java.security.SecureRandom;
import java.security.spec.InvalidKeySpecException;
import javax.crypto.BadPaddingException;
import javax.crypto.Cipher;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.NoSuchPaddingException;
import javax.crypto.SecretKey;
import javax.crypto.SecretKeyFactory;
import javax.crypto.ShortBufferException;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.PBEKeySpec;
import javax.crypto.spec.SecretKeySpec;
import static sun.security.krb5.Confounder.bytes;

/**
 *
 * @author student
 */
public class AESKey {
    /**
     * @param args the command line arguments
  
     */
    
    public static void main(String[] args) throws IllegalBlockSizeException, ShortBufferException, InvalidKeyException, BadPaddingException, NoSuchAlgorithmException, NoSuchPaddingException, InvalidAlgorithmParameterException, InvalidKeySpecException
    {
       char[] password = "short_password".toCharArray();
       byte[] salt = new byte[16];
       int iteration_count = 10000;
       int key_size = 128;
      byte[] keyBytes = new byte[16];
// declare secure PRNG
SecureRandom myPRNG = new SecureRandom();
// seed the key
myPRNG.nextBytes(keyBytes);
// build the key from random key bytes
SecretKeySpec myKey = new SecretKeySpec(keyBytes, "AES");
// instantiate AES object for ECB with no padding
Cipher myAES = Cipher.getInstance("AES/CBC/PKCS5Padding");
// initialize AES objecy to encrypt mode
myAES.init(Cipher.ENCRYPT_MODE, myKey,new IvParameterSpec(new byte[16]));
// initialize plaintext
byte[] plaintext = new byte[16];
plaintext = javax.xml.bind.DatatypeConverter.parseHexBinary("AABBCCDDAABBCCDDAABBCCDDAABBCCDD");
//initialize ciphertext
byte[] ciphertext = new byte[32];
// update cipher with the plaintext
int cLength = myAES.update(plaintext, 0, plaintext.length, ciphertext, 
0);
// process remaining blocks of plaintext
cLength += myAES.doFinal(ciphertext, cLength);
// print plaintext and ciphertext
System.out.println("plaintext: " + 
javax.xml.bind.DatatypeConverter.printHexBinary(plaintext));
System.out.println("ciphertext: " + 
javax.xml.bind.DatatypeConverter.printHexBinary(ciphertext));
// initialize AES for decryption
myAES.init(Cipher.DECRYPT_MODE, myKey,new IvParameterSpec(new byte[16]));
// initialize a new array of bytes to place the decryption
byte[] dec_plaintext = new byte[16];
cLength = myAES.update(ciphertext, 0, ciphertext.length, dec_plaintext, 
0);
// process remaining blocks of ciphertext
cLength += myAES.doFinal(dec_plaintext, cLength);
// print the new plaintext (hopefully identical to the initial one)
System.out.println("decrypted: " + 
javax.xml.bind.DatatypeConverter.printHexBinary(dec_plaintext));
// get a Cipher instance for RSA with PKCS1 padding
Cipher myRSA = Cipher.getInstance("RSA/ECB/PKCS1Padding");
// get an instance for the Key Generator
KeyPairGenerator myRSAKeyGen = KeyPairGenerator.getInstance("RSA");
// generate an 1024 bit key
myRSAKeyGen.initialize(1024, myPRNG);
KeyPair myRSAKeyPair= myRSAKeyGen.generateKeyPair();
// store the public and private key individually
Key pbKey = myRSAKeyPair.getPublic();
Key pvKey = myRSAKeyPair.getPrivate();
// init cipher for encryption
myRSA.init(Cipher.ENCRYPT_MODE, pbKey, myPRNG);

ciphertext = myRSA.doFinal(keyBytes);
// init cipher for decryption 
myRSA.init(Cipher.DECRYPT_MODE, pvKey);
// decrypt
plaintext = myRSA.doFinal(ciphertext);
System.out.println("plaintext: " + 
javax.xml.bind.DatatypeConverter.printHexBinary(plaintext));
System.out.println("ciphertext: " + 
javax.xml.bind.DatatypeConverter.printHexBinary(ciphertext));
System.out.println("keybytes: " + 
javax.xml.bind.DatatypeConverter.printHexBinary(keyBytes));
myPRNG.nextBytes(salt);
 
// initialize key factory for HMAC-SHA1 derivation
SecretKeyFactory keyFactory = SecretKeyFactory.getInstance("PBKDF2WithHmacSHA1"); 
// set key specification
PBEKeySpec pbekSpec = new PBEKeySpec(password, salt, iteration_count, 
key_size);
// generate the key
SecretKey myAESPBKey = new SecretKeySpec( 
keyFactory.generateSecret(pbekSpec).getEncoded(), "AES");
// print the key
System.out.println("AES key: " + 
javax.xml.bind.DatatypeConverter.printHexBinary(myAESPBKey.getEncoded()));

    }
    
}
