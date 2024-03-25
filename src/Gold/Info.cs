using Gold.Graphics;
using IL2CPU.API.Attribs;

namespace Gold;

public class Info
{
    [ManifestResourceStream(ResourceName = "GoGL.Resources.logo.bmp")]
    static byte[] GoldLogoRaw;

    public Canvas GoldLogo;

    public String GetVersion()
    {
        return "0.0.1";
    }

    public String GetApiVersion()
    {
        return "1.3";
    }

    public Canvas GetLogo()
    {
        GoldLogo = Image.FromBitmap(GoldLogoRaw, false);
        return GoldLogo;
    }
}