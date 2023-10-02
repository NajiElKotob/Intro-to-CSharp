using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;

namespace QRGenDemo;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void GenerateQRButton_Click(object sender, EventArgs e)
    {
        // Get the text you want to encode in the QR code
        string textToEncode = QRCodeTextBox.Text;

        // Set the barcode format to QR code
        QrCodeEncodingOptions options = new()
        {
            DisableECI = true,
            CharacterSet = "UTF-8",
            Width = 300,
            Height = 300
        };
        // Create a BarcodeWriter instance
        BarcodeWriter barcodeWriter = new()
        {
            Format = BarcodeFormat.QR_CODE,
            Options = options
        };

        //barcodeWriter.Format = BarcodeFormat.QR_CODE;

        // Generate the QR code as a Bitmap
        Bitmap qrCodeBitmap = barcodeWriter.Write(textToEncode);

        // Display the QR code in the PictureBox
        QRCodePictureBox.Image = qrCodeBitmap;
    }
}