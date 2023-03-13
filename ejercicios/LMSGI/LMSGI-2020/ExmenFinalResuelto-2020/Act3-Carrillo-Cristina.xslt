<?xml version="1.0" encoding="UTF-8"?>
<!-- Cristina Carrillo Reyes 1 DAM-M -->
<!-- DNI 74696006-X-->
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
    <html>
      <body>
        <h3 style="color: blue;">Cristina Carrillo Act 3</h3>><!-- se mostrará en el navegador el nombre del ejercicio en letras grandes y  azul-->
        <xsl:for-each select="usuarios/usuario">
          <a>
            <xsl:value-of select="username"/><!-- se mostrará en el navegador los username de los usuarios-->
            <br/>
          </a>
        </xsl:for-each>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
