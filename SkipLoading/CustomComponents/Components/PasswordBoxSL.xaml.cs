using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomComponents.Components
{
    /// <summary>
    /// Interaction logic for PasswordBoxSL.xaml
    /// </summary>
    public partial class PasswordBoxSL : UserControl
    {
        /// <summary>
        /// Flag indicating if the password is changing from UI or was set from the code
        /// </summary>
        private bool _isPasswordChanging;

        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PasswordProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(PasswordBoxSL), 
                new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, PasswordPropertyChanged,
                    null, false, UpdateSourceTrigger.PropertyChanged));

        /// <summary>
        /// Called everytime when the Password property was changed
        /// </summary>
        /// <param name="d">The instance of this class</param>
        /// <param name="e">Event arguments</param>
        private static void PasswordPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is PasswordBoxSL passwordBox)
            {
                passwordBox.UpdatePassword();
            }
        }

        public PasswordBoxSL()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Password changed event for the password field
        /// </summary>
        /// <param name="sender">The password field</param>
        /// <param name="e">Password field event args</param>
        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            _isPasswordChanging = true;
            Password = passwordBox.Password;
            _isPasswordChanging = false;
        }

        /// <summary>
        /// Sets the password to UI
        /// </summary>
        private void UpdatePassword()
        {
            if(!_isPasswordChanging)
            {
                passwordBox.Password = Password;
            }
        }
    }
}
