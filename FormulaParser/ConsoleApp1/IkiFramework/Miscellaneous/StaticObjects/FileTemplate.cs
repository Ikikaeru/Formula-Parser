namespace IkiCore.Miscellaneous
{
    public static class FileTemplate
    {
        public static string HTML_Body(string projectName, string bodyContent, string cssName = "style", string jsName = "main") => $"<!DOCTYPE html>\n<html>\n\t<head>\n\t\t<title>{projectName}</title>\n\t\t<meta charset=\"UTF-8\" name=\"viewport\" content=\"width = device-width, height = device-height, initial-scale = 1, shrink-to-fit = no\"/>\n\t\t<link href=\"css/{cssName}.css\" rel=\"stylesheet\"/>\n\t\t<script type=\"application/javascript\" src=\"js/{jsName}.js\"/></script>\n\t</head>\n\t<body>\n\t{bodyContent}</body>\n</html>";
        public static string CSS_Body() => "html, body\n{\n\tpadding: 0;\n\tmargin: 0;\n\twidth: 100%;\n\theight: 100%;\n}";
    }
}
