% Створити модель штучної нейронної мережі (ШНМ) за діаграмою (варіант 6)
inputSize = 2;
hiddenLayerSize = 8;
outputSize = 1;

net = feedforwardnet(hiddenLayerSize);
input_data = [10 1; 11 2; 12 3]';
output_data = [5; 8; 3]';

net.trainParam.epochs = 1000;
net.trainParam.lr = 0.01;

[net, ~] = train(net, input_data, output_data);

test_input = [13 4]';
predicted_output = net(test_input);
disp(['Predicted Output for Test Input: ' num2str(predicted_output)]);