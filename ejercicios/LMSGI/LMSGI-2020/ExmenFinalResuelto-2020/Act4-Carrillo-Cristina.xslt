<?xml version="1.0" encoding="UTF-8"?>
<!-- Cristina Carrillo Reyes 1 DAM-M -->
<!-- DNI 74696006-X-->
<!-- En este ejercicio me ayudó mi compañera juliia porque no me  salia-->
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
    <h3 style="color: pink;">Cristina Carrillo Act 4</h3>
    <!-- se mostrará en el navegador el nombre del ejercicio con las letras en rosa-->
    <usuarios>
      <xsl:for-each select="usuarios/usuario"><!-- por cada usuario se insertan sus datos del ejericio 1 -->
        <xsl:element name="usuario">
          <xsl:attribute name="status"> <!-- se mostrará en el navegador el nombre del usuario. Cambia de estado a status -->
            <xsl:value-of select="@estado"/><!-- hay que poner la @ porque es un atributo -->
          </xsl:attribute>
          <xsl:element name="apellido">
            <!-- se mostrará en el navegador el apellido del usuario-->
            <br/>
            <xsl:value-of select="apellido"/>
          </xsl:element>
          <xsl:element name="name">
            <!-- se mostrará en el navegador el nombre del usuario. Cambia de nombre a name-->
            <xsl:value-of select="nombre"/>
          </xsl:element>
          <xsl:element name="fecha_de_registro">
            <!-- se mostrará en el navegador la fecha de registro del usuario-->
            <br/>
            <xsl:value-of select="fecha_de_registro"/>
          </xsl:element>
          <xsl:element name="username">
            <!-- se mostrará en el navegador el username del usuario-->
            <br/>
            <xsl:value-of select="username"/>
          </xsl:element>
          <xsl:if test="fecha_de_baja">
            <xsl:element name="fecha_de_baja">
              <!-- se mostrará en el navegador la fecha de baja del usuario-->
              <br/>
              <xsl:value-of select="fecha_de_baja"/>
            </xsl:element>
          </xsl:if>
        </xsl:element>
        <br/>
        <br/>
      </xsl:for-each>
    </usuarios>
  </xsl:template>
</xsl:stylesheet>
