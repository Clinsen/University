public class TextEncryption {
    private static final String key = "Кишинський Олександр Костянтинович";

    public static void main(String[] args) {
        String plaintext = "Щоб одержати \"завантажвувальний модуль\" потрібно здійснити інтерпритацію байт-кодів у команди конкретного процесора, для кожної комп'ютерної архітектури (платформи), тобто для кожної операційної системи.";
        String ciphertext = encrypt(plaintext);
        String decryptedText = decrypt(ciphertext);
        System.out.println("Original text: " + plaintext);
        System.out.println("Encrypted text: " + ciphertext);
        System.out.println("Decrypted text: " + decryptedText);
    }

    private static String encrypt(String plaintext) {
        String encryptedText = "";
        for (int i = 0; i < plaintext.length(); i++) {
            char c = plaintext.charAt(i);
            int keyIndex = i % key.length();
            char keyChar = key.charAt(keyIndex);
            int shift = (int) keyChar;
            char encryptedChar = (char) (c + shift);
            encryptedText += encryptedChar;
        }
        return encryptedText;
    }

    private static String decrypt(String ciphertext) {
        String decryptedText = "";
        for (int i = 0; i < ciphertext.length(); i++) {
            char c = ciphertext.charAt(i);
            int keyIndex = i % key.length();
            char keyChar = key.charAt(keyIndex);
            int shift = (int) keyChar;
            char decryptedChar = (char) (c - shift);
            decryptedText += decryptedChar;
        }
        return decryptedText;
    }
}