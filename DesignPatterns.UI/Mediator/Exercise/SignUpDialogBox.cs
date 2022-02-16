namespace DesignPatterns.UI.Mediator.Exercise
{
    public class SignUpDialogBox
    {
        private readonly TextBox _username;
        private readonly TextBox _password;
        private readonly CheckBox _agreeWithTerms;
        private readonly Button _signUpBtn;

        public SignUpDialogBox(TextBox username, TextBox password, CheckBox agreeWithTerms, Button signUpBtn)
        {
            _username = username;
            _username.AddEventHandler(FormUpdated);
            _password = password;
            _password.AddEventHandler(FormUpdated);
            _agreeWithTerms = agreeWithTerms;
            _agreeWithTerms.AddEventHandler(FormUpdated);
            _signUpBtn = signUpBtn;
        }

        private void FormUpdated()
        {
            _signUpBtn.SetEnabled(!_username.IsEmpty() && 
                !_password.IsEmpty() &&
                _agreeWithTerms.IsChecked);
        }
    }
}