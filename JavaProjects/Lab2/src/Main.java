public class Main {
    public static void main(String[] args)
    {
        String[] array = {
                "Національний лісотехнічний університет України",
                "Навчально-науковий інститут дереворобних та комп'ютерних технологій і дизайну",
                "КНС-11",
                "122 - Комп'ютерні науки"
        };

        String speciality_str = array[3];
        System.out.println("===== Get Speciality =====\n" + speciality_str);

        char[] uni_name = array[0].toCharArray();
        StringBuilder mirror_str = new StringBuilder();
        for (int i = uni_name.length-1; i>=0; i--)
        {
            mirror_str.append(uni_name[i]);
        }
        System.out.println("\n===== Get Mirrored Uni Name =====\n" + mirror_str);

        String str3 = array[0].toUpperCase();
        System.out.println("\n===== Uni Name To Uppercase =====\n" + str3);
        System.out.println("Are they equal? - " + array[0].equals(str3));

        System.out.println("\n===== Printing faculty name =====\n" + array[1]);

        String str4 = array[0] + "; " + array[2];
        System.out.println("\n===== Concatenate strings =====\n" + str4);

        // Краще було використати методи first та lastIndexOf();
        System.out.println("\n===== First appearance of the character in a string array =====");
        char[] char_index = array[0].toCharArray();
        char selected_char = 'і';
        for(int i = 0; i < char_index.length; i++)
        {
            if (char_index[i] == selected_char)
            {
                System.out.println("Found first appearance of character " + selected_char + " at index " + i);
                break;
            }
        }

        for(int i = char_index.length - 1; i >= 0; i--)
        {
            if (char_index[i] == selected_char)
            {
                System.out.println("Found last appearance of character " + selected_char + " at index " + i);
                break;
            }
        }

        StringBuffer sb = new StringBuffer("Кишинський Олександр Костянтинович, 24.01.1899");
        System.out.println("\n===== Deleting date and month =====");
        sb.delete(36, 42);
        System.out.println(sb);

        System.out.println("\n===== Add place of birth =====");
        sb.append(", Lviv");
        System.out.println(sb);

        System.out.println("\n===== Insert gender =====");
        sb.insert(42, "Male, ");
        System.out.println(sb);

        // Прийшлося зробити копію бо метод getBytes не працює зі StringBuffer
        String copy = String.valueOf(sb);
        System.out.println("\n===== Length =====\n" + sb.length() + "\n\n===== Bytes =====\n" + copy.getBytes().length);

        System.out.println("\n===== Shorten the buffer =====");
        sb.delete(34, sb.length());
        System.out.println(sb);

        System.out.println("\n===== Reverse the surname =====");
        char[] surname = sb.substring(0, sb.indexOf(" ")).toCharArray();
        StringBuilder reverse_surname = new StringBuilder();
        for (int i = surname.length-1; i>=0; i--)
        {
            reverse_surname.append(surname[i]);
        }
        System.out.println(reverse_surname);
    }
}