using TMPro;
using UnityEngine;

public class TwoNumbersComparer : MonoBehaviour {
    [SerializeField] private TMP_InputField _inputFieldFirstValue;
    [SerializeField] private TMP_InputField _inputFieldSecondValue;
    [SerializeField] private TMP_InputField _inputFieldResultValue;

    public void OnCompareButton() {
        if (_inputFieldFirstValue.text == "") {
            _inputFieldResultValue.text = "First value empty!";
            return;
        }
        if (_inputFieldSecondValue.text == "") {
            _inputFieldResultValue.text = "Second value empty!";
            return;
        }
        double firstValue = double.Parse(_inputFieldFirstValue.text);
        double secondValue = double.Parse(_inputFieldSecondValue.text);
        if (firstValue > secondValue) {
            _inputFieldResultValue.text = _inputFieldFirstValue.text;
        } else if (secondValue > firstValue) {
            _inputFieldResultValue.text = _inputFieldSecondValue.text;
        } else {
            _inputFieldResultValue.text = "Equals!";
        }
    }
}
