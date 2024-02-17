namespace _8 {
    public static class TextBoxMediator {
        private static readonly Dictionary<TextBox, List<TextBox>> textBoxMap = new Dictionary<TextBox, List<TextBox>>();

        public static void RegisterTextBox(TextBox sender, params TextBox[] textBoxes) {
            if (!textBoxMap.ContainsKey(sender)) {
                textBoxMap[sender] = new List<TextBox>();
            }

            foreach (var textBox in textBoxes) {
                if (textBox != sender && !textBoxMap[sender].Contains(textBox)) {
                    textBoxMap[sender].Add(textBox);
                    textBox.TextChanged += (s, e) => sender.Text = textBox.Text;
                }
            }
        }
    }
}
