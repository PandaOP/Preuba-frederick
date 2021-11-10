/*
 Navicat Premium Data Transfer

 Source Server         : Base de Datos 2
 Source Server Type    : MySQL
 Source Server Version : 80023
 Source Host           : 127.0.0.1:3306
 Source Schema         : arka

 Target Server Type    : MySQL
 Target Server Version : 80023
 File Encoding         : 65001

 Date: 02/11/2021 22:07:04
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for citas
-- ----------------------------
DROP TABLE IF EXISTS `citas`;
CREATE TABLE `citas`  (
  `id_cita` int NOT NULL AUTO_INCREMENT,
  `id_cliente` int NULL DEFAULT NULL,
  `id_estado_cita` int NULL DEFAULT NULL,
  `id_veterinario` int NULL DEFAULT NULL,
  `fecha_cita` date NULL DEFAULT NULL,
  `hora_inicio` time(0) NULL DEFAULT NULL,
  `hora_final` time(0) NULL DEFAULT NULL,
  `descripcion_cita` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_cita`) USING BTREE,
  INDEX `id_cliente`(`id_cliente`) USING BTREE,
  INDEX `id_estado_cita`(`id_estado_cita`) USING BTREE,
  INDEX `id_veterinario`(`id_veterinario`) USING BTREE,
  CONSTRAINT `citas_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_cliente`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `citas_ibfk_2` FOREIGN KEY (`id_estado_cita`) REFERENCES `estado_citas` (`id_estado_cita`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `citas_ibfk_3` FOREIGN KEY (`id_veterinario`) REFERENCES `veterinarios` (`id_veterinario`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of citas
-- ----------------------------
INSERT INTO `citas` VALUES (1, 1, 1, 1, '2021-11-01', '17:00:00', '18:00:00', NULL);
INSERT INTO `citas` VALUES (2, 1, 1, 1, '2021-11-01', '09:00:00', '10:00:00', NULL);
INSERT INTO `citas` VALUES (3, 1, 1, 1, '2021-11-01', '16:00:00', '17:00:00', NULL);
INSERT INTO `citas` VALUES (4, 1, 1, 1, '2021-10-31', '07:00:00', '08:00:00', NULL);
INSERT INTO `citas` VALUES (17, 2, NULL, 1, '2021-02-02', '18:00:00', '19:00:00', 'hola como etas');
INSERT INTO `citas` VALUES (18, 2, NULL, 1, '2021-02-02', '16:00:00', '17:00:00', 'hola como etas');
INSERT INTO `citas` VALUES (20, 2, NULL, 1, '2021-02-02', '14:00:00', '15:00:00', 'hola como etas');
INSERT INTO `citas` VALUES (21, 2, 1, 1, '2021-02-03', '14:00:00', '15:00:00', 'hola como etas');

-- ----------------------------
-- Table structure for clientes
-- ----------------------------
DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes`  (
  `id_cliente` int NOT NULL AUTO_INCREMENT,
  `cedula` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_cliente`) USING BTREE,
  INDEX `cedula`(`cedula`) USING BTREE,
  CONSTRAINT `clientes_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `personas` (`cedula`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of clientes
-- ----------------------------
INSERT INTO `clientes` VALUES (2, '489-300301-1003Y');
INSERT INTO `clientes` VALUES (1, 'C2');

-- ----------------------------
-- Table structure for consulta_enfermedades
-- ----------------------------
DROP TABLE IF EXISTS `consulta_enfermedades`;
CREATE TABLE `consulta_enfermedades`  (
  `id_consulta_enfermedad` int NOT NULL AUTO_INCREMENT,
  `id_enfermedad` int NULL DEFAULT NULL,
  `id_consulta` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_consulta_enfermedad`) USING BTREE,
  INDEX `id_enfermedad`(`id_enfermedad`) USING BTREE,
  INDEX `id_consulta`(`id_consulta`) USING BTREE,
  CONSTRAINT `consulta_enfermedades_ibfk_1` FOREIGN KEY (`id_enfermedad`) REFERENCES `enfermedades` (`id_enfermedad`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `consulta_enfermedades_ibfk_2` FOREIGN KEY (`id_consulta`) REFERENCES `consultas` (`id_consulta`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of consulta_enfermedades
-- ----------------------------

-- ----------------------------
-- Table structure for consultas
-- ----------------------------
DROP TABLE IF EXISTS `consultas`;
CREATE TABLE `consultas`  (
  `id_consulta` int NOT NULL,
  `id_veterinario` int NULL DEFAULT NULL,
  `id_mascota` int NULL DEFAULT NULL,
  `id_cliente` int NULL DEFAULT NULL,
  `peso` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `temperatura` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `fecha_consulta` date NULL DEFAULT NULL,
  `descripcion_consulta` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_consulta`) USING BTREE,
  INDEX `id_veterinario`(`id_veterinario`) USING BTREE,
  INDEX `id_mascota`(`id_mascota`) USING BTREE,
  INDEX `id_cliente`(`id_cliente`) USING BTREE,
  CONSTRAINT `consultas_ibfk_1` FOREIGN KEY (`id_veterinario`) REFERENCES `vendedores` (`id_vendedor`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `consultas_ibfk_2` FOREIGN KEY (`id_mascota`) REFERENCES `mascotas` (`id_mascota`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `consultas_ibfk_3` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_cliente`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of consultas
-- ----------------------------

-- ----------------------------
-- Table structure for departamentos
-- ----------------------------
DROP TABLE IF EXISTS `departamentos`;
CREATE TABLE `departamentos`  (
  `id_departamento` int NOT NULL AUTO_INCREMENT,
  `nombre_departamento` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_departamento`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of departamentos
-- ----------------------------
INSERT INTO `departamentos` VALUES (1, 'Esteli');

-- ----------------------------
-- Table structure for direcciones
-- ----------------------------
DROP TABLE IF EXISTS `direcciones`;
CREATE TABLE `direcciones`  (
  `id_direccion` int NOT NULL AUTO_INCREMENT,
  `id_municipio` int NULL DEFAULT NULL,
  `descripcion_direccion` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_direccion`) USING BTREE,
  INDEX `id_municipio`(`id_municipio`) USING BTREE,
  CONSTRAINT `direcciones_ibfk_1` FOREIGN KEY (`id_municipio`) REFERENCES `municipios` (`id_municipio`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of direcciones
-- ----------------------------
INSERT INTO `direcciones` VALUES (1, 1, 'De los mormones 3c al este');
INSERT INTO `direcciones` VALUES (2, 1, 'De operaciones 3c al este');

-- ----------------------------
-- Table structure for enfermedad_tipo_animal
-- ----------------------------
DROP TABLE IF EXISTS `enfermedad_tipo_animal`;
CREATE TABLE `enfermedad_tipo_animal`  (
  `id_tipo_enfermedad_animal` int NOT NULL AUTO_INCREMENT,
  `id_enfermedad` int NULL DEFAULT NULL,
  `id_tipo_animal` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_tipo_enfermedad_animal`) USING BTREE,
  INDEX `id_enfermedad`(`id_enfermedad`) USING BTREE,
  INDEX `id_tipo_animal`(`id_tipo_animal`) USING BTREE,
  CONSTRAINT `enfermedad_tipo_animal_ibfk_1` FOREIGN KEY (`id_enfermedad`) REFERENCES `enfermedades` (`id_enfermedad`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `enfermedad_tipo_animal_ibfk_2` FOREIGN KEY (`id_tipo_animal`) REFERENCES `tipo_animales` (`id_tipo_animal`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of enfermedad_tipo_animal
-- ----------------------------

-- ----------------------------
-- Table structure for enfermedades
-- ----------------------------
DROP TABLE IF EXISTS `enfermedades`;
CREATE TABLE `enfermedades`  (
  `id_enfermedad` int NOT NULL AUTO_INCREMENT,
  `descripcion_enfermedad` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_enfermedad`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of enfermedades
-- ----------------------------

-- ----------------------------
-- Table structure for estado_cita
-- ----------------------------
DROP TABLE IF EXISTS `estado_cita`;
CREATE TABLE `estado_cita`  (
  `Id_Estado_citas` int NOT NULL AUTO_INCREMENT,
  `Descripcion_estado_citas` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id_Estado_citas`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of estado_cita
-- ----------------------------

-- ----------------------------
-- Table structure for estado_citas
-- ----------------------------
DROP TABLE IF EXISTS `estado_citas`;
CREATE TABLE `estado_citas`  (
  `id_estado_cita` int NOT NULL AUTO_INCREMENT,
  `descripcion_estado_cita` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_estado_cita`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of estado_citas
-- ----------------------------
INSERT INTO `estado_citas` VALUES (1, 'pendiente');
INSERT INTO `estado_citas` VALUES (2, 'finalizada');
INSERT INTO `estado_citas` VALUES (3, 'cancelada');

-- ----------------------------
-- Table structure for estado_mascota
-- ----------------------------
DROP TABLE IF EXISTS `estado_mascota`;
CREATE TABLE `estado_mascota`  (
  `Id_estado_mascota` int NOT NULL AUTO_INCREMENT,
  `Descripcion_estado_mascota` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id_estado_mascota`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of estado_mascota
-- ----------------------------
INSERT INTO `estado_mascota` VALUES (1, 'Vivo');
INSERT INTO `estado_mascota` VALUES (2, 'Muerto');

-- ----------------------------
-- Table structure for estado_usuario
-- ----------------------------
DROP TABLE IF EXISTS `estado_usuario`;
CREATE TABLE `estado_usuario`  (
  `id_estado_usuario` int NOT NULL AUTO_INCREMENT,
  `descripcion_estado` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_estado_usuario`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of estado_usuario
-- ----------------------------
INSERT INTO `estado_usuario` VALUES (1, 'activo');
INSERT INTO `estado_usuario` VALUES (2, 'logeado');
INSERT INTO `estado_usuario` VALUES (3, 'inactivo');

-- ----------------------------
-- Table structure for estado_usuarios
-- ----------------------------
DROP TABLE IF EXISTS `estado_usuarios`;
CREATE TABLE `estado_usuarios`  (
  `id_estado_usuario` int NOT NULL AUTO_INCREMENT,
  `descripcion_estado` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_estado_usuario`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of estado_usuarios
-- ----------------------------
INSERT INTO `estado_usuarios` VALUES (1, 'Activo');
INSERT INTO `estado_usuarios` VALUES (2, 'Inactivo');

-- ----------------------------
-- Table structure for inventario
-- ----------------------------
DROP TABLE IF EXISTS `inventario`;
CREATE TABLE `inventario`  (
  `id_producto` int NOT NULL,
  `cantidad_existente` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_producto`) USING BTREE,
  CONSTRAINT `inventario_ibfk_1` FOREIGN KEY (`id_producto`) REFERENCES `producto` (`id_Producto`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of inventario
-- ----------------------------

-- ----------------------------
-- Table structure for inventarios
-- ----------------------------
DROP TABLE IF EXISTS `inventarios`;
CREATE TABLE `inventarios`  (
  `id_ptoducto` int NOT NULL AUTO_INCREMENT,
  `cantidad_existente` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_ptoducto`) USING BTREE,
  CONSTRAINT `inventarios_ibfk_1` FOREIGN KEY (`id_ptoducto`) REFERENCES `productos` (`id_producto`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of inventarios
-- ----------------------------

-- ----------------------------
-- Table structure for mascotas
-- ----------------------------
DROP TABLE IF EXISTS `mascotas`;
CREATE TABLE `mascotas`  (
  `id_mascota` int NOT NULL AUTO_INCREMENT,
  `nombre_mascota` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `fecha_nacimiento` date NULL DEFAULT NULL,
  `id_propietario` int NULL DEFAULT NULL,
  `sexo` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `id_raza` int NULL DEFAULT NULL,
  `id_estado_mascota` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_mascota`) USING BTREE,
  INDEX `id_propietario`(`id_propietario`) USING BTREE,
  INDEX `id_raza`(`id_raza`) USING BTREE,
  INDEX `id_estado_mascota`(`id_estado_mascota`) USING BTREE,
  CONSTRAINT `mascotas_ibfk_1` FOREIGN KEY (`id_propietario`) REFERENCES `propietarios` (`id_propietario`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `mascotas_ibfk_2` FOREIGN KEY (`id_raza`) REFERENCES `raza` (`id_raza`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `mascotas_ibfk_3` FOREIGN KEY (`id_estado_mascota`) REFERENCES `estado_mascota` (`Id_estado_mascota`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 8 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of mascotas
-- ----------------------------
INSERT INTO `mascotas` VALUES (7, 'Dati', '2018-03-30', 1, 'Hembra', 1, 1);

-- ----------------------------
-- Table structure for municipios
-- ----------------------------
DROP TABLE IF EXISTS `municipios`;
CREATE TABLE `municipios`  (
  `id_municipio` int NOT NULL AUTO_INCREMENT,
  `id_departamento` int NULL DEFAULT NULL,
  `nombre_municipio` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_municipio`) USING BTREE,
  INDEX `id_departamento`(`id_departamento`) USING BTREE,
  CONSTRAINT `municipios_ibfk_1` FOREIGN KEY (`id_departamento`) REFERENCES `departamentos` (`id_departamento`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of municipios
-- ----------------------------
INSERT INTO `municipios` VALUES (1, 1, 'Esteli');

-- ----------------------------
-- Table structure for personas
-- ----------------------------
DROP TABLE IF EXISTS `personas`;
CREATE TABLE `personas`  (
  `cedula` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `nombre_personas` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `apellido_personas` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `id_telefono` int NULL DEFAULT NULL,
  `id_direccion` int NULL DEFAULT NULL,
  PRIMARY KEY (`cedula`) USING BTREE,
  INDEX `id_telefono`(`id_telefono`) USING BTREE,
  INDEX `id_direccion`(`id_direccion`) USING BTREE,
  CONSTRAINT `personas_ibfk_1` FOREIGN KEY (`id_telefono`) REFERENCES `telefonos` (`id_telefono`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `personas_ibfk_2` FOREIGN KEY (`id_direccion`) REFERENCES `direcciones` (`id_direccion`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of personas
-- ----------------------------
INSERT INTO `personas` VALUES ('489-300301-1003Y', 'kevin Ernesto', 'Cardoza Lopez', 1, 1);
INSERT INTO `personas` VALUES ('C2', 'Danny Josue', 'Tercero Telles', 2, 2);

-- ----------------------------
-- Table structure for producto
-- ----------------------------
DROP TABLE IF EXISTS `producto`;
CREATE TABLE `producto`  (
  `id_producto` int NOT NULL AUTO_INCREMENT,
  `nombre_producto` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `id_tipo_producto` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_producto`) USING BTREE,
  INDEX `id_tipo_producto`(`id_tipo_producto`) USING BTREE,
  CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`id_tipo_producto`) REFERENCES `tipo_producto` (`Id_tipo_producto`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of producto
-- ----------------------------

-- ----------------------------
-- Table structure for productos
-- ----------------------------
DROP TABLE IF EXISTS `productos`;
CREATE TABLE `productos`  (
  `id_producto` int NOT NULL AUTO_INCREMENT,
  `nombre_producto` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `id_tipo_producto` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_producto`) USING BTREE,
  INDEX `id_tipo_producto`(`id_tipo_producto`) USING BTREE,
  CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`id_tipo_producto`) REFERENCES `tipo_productos` (`id_tipo_producto`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of productos
-- ----------------------------

-- ----------------------------
-- Table structure for propietarios
-- ----------------------------
DROP TABLE IF EXISTS `propietarios`;
CREATE TABLE `propietarios`  (
  `id_propietario` int NOT NULL AUTO_INCREMENT,
  `cedula` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_propietario`) USING BTREE,
  INDEX `cedula`(`cedula`) USING BTREE,
  CONSTRAINT `propietarios_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `personas` (`cedula`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of propietarios
-- ----------------------------
INSERT INTO `propietarios` VALUES (1, '489-300301-1003Y');

-- ----------------------------
-- Table structure for raza
-- ----------------------------
DROP TABLE IF EXISTS `raza`;
CREATE TABLE `raza`  (
  `id_raza` int NOT NULL AUTO_INCREMENT,
  `raza_descripcion` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `id_tipo_animal` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_raza`) USING BTREE,
  INDEX `id_tipo_animal`(`id_tipo_animal`) USING BTREE,
  CONSTRAINT `raza_ibfk_1` FOREIGN KEY (`id_tipo_animal`) REFERENCES `tipo_animales` (`id_tipo_animal`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of raza
-- ----------------------------
INSERT INTO `raza` VALUES (1, 'Dalmata', 1);
INSERT INTO `raza` VALUES (2, 'Pastor Aleman', 1);

-- ----------------------------
-- Table structure for telefonos
-- ----------------------------
DROP TABLE IF EXISTS `telefonos`;
CREATE TABLE `telefonos`  (
  `id_telefono` int NOT NULL AUTO_INCREMENT,
  `id_tipo_telefono` int NULL DEFAULT NULL,
  `numero_telefono` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_telefono`) USING BTREE,
  INDEX `id_tipo_telefono`(`id_tipo_telefono`) USING BTREE,
  CONSTRAINT `telefonos_ibfk_1` FOREIGN KEY (`id_tipo_telefono`) REFERENCES `tipo_telefonos` (`id_tipo_telefono`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of telefonos
-- ----------------------------
INSERT INTO `telefonos` VALUES (1, 1, 89377967);
INSERT INTO `telefonos` VALUES (2, 1, 58589595);

-- ----------------------------
-- Table structure for tipo_animales
-- ----------------------------
DROP TABLE IF EXISTS `tipo_animales`;
CREATE TABLE `tipo_animales`  (
  `id_tipo_animal` int NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_tipo_animal`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of tipo_animales
-- ----------------------------
INSERT INTO `tipo_animales` VALUES (1, 'canino');

-- ----------------------------
-- Table structure for tipo_producto
-- ----------------------------
DROP TABLE IF EXISTS `tipo_producto`;
CREATE TABLE `tipo_producto`  (
  `id_tipo_producto` int NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_tipo_producto`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of tipo_producto
-- ----------------------------
INSERT INTO `tipo_producto` VALUES (1, 'Alimentos');
INSERT INTO `tipo_producto` VALUES (2, 'Medicamentos');
INSERT INTO `tipo_producto` VALUES (3, 'Accesorios');

-- ----------------------------
-- Table structure for tipo_productos
-- ----------------------------
DROP TABLE IF EXISTS `tipo_productos`;
CREATE TABLE `tipo_productos`  (
  `id_tipo_producto` int NOT NULL AUTO_INCREMENT,
  `descripcion_tipo_producto` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_tipo_producto`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of tipo_productos
-- ----------------------------

-- ----------------------------
-- Table structure for tipo_telefonos
-- ----------------------------
DROP TABLE IF EXISTS `tipo_telefonos`;
CREATE TABLE `tipo_telefonos`  (
  `id_tipo_telefono` int NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_tipo_telefono`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of tipo_telefonos
-- ----------------------------
INSERT INTO `tipo_telefonos` VALUES (1, 'claro');
INSERT INTO `tipo_telefonos` VALUES (2, 'movistar');

-- ----------------------------
-- Table structure for tipo_usuarios
-- ----------------------------
DROP TABLE IF EXISTS `tipo_usuarios`;
CREATE TABLE `tipo_usuarios`  (
  `id_tipo_usuario` int NOT NULL AUTO_INCREMENT,
  `descripcion_tipo_usuario` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_tipo_usuario`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of tipo_usuarios
-- ----------------------------
INSERT INTO `tipo_usuarios` VALUES (1, 'Usuario');
INSERT INTO `tipo_usuarios` VALUES (2, 'Veterinario');
INSERT INTO `tipo_usuarios` VALUES (3, 'Administrador');
INSERT INTO `tipo_usuarios` VALUES (4, 'Vendedor');

-- ----------------------------
-- Table structure for usuarios
-- ----------------------------
DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios`  (
  `cedula` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `alias` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `clave` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `id_estado_usuario` int NULL DEFAULT NULL,
  `id_tipo_usuario` int NULL DEFAULT NULL,
  PRIMARY KEY (`cedula`) USING BTREE,
  INDEX `id_estado_usuario`(`id_estado_usuario`) USING BTREE,
  INDEX `id_tipo_usuario`(`id_tipo_usuario`) USING BTREE,
  CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`id_estado_usuario`) REFERENCES `estado_usuario` (`id_estado_usuario`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `usuarios_ibfk_2` FOREIGN KEY (`id_tipo_usuario`) REFERENCES `tipo_usuarios` (`id_tipo_usuario`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `usuarios_ibfk_3` FOREIGN KEY (`cedula`) REFERENCES `personas` (`cedula`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of usuarios
-- ----------------------------
INSERT INTO `usuarios` VALUES ('489-300301-1003Y', 'pevin', '123', 3, 3);

-- ----------------------------
-- Table structure for vendedor
-- ----------------------------
DROP TABLE IF EXISTS `vendedor`;
CREATE TABLE `vendedor`  (
  `id_vendedor` int NOT NULL,
  `cedula` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_vendedor`) USING BTREE,
  INDEX `cedula`(`cedula`) USING BTREE,
  CONSTRAINT `vendedor_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `personas` (`cedula`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of vendedor
-- ----------------------------

-- ----------------------------
-- Table structure for vendedores
-- ----------------------------
DROP TABLE IF EXISTS `vendedores`;
CREATE TABLE `vendedores`  (
  `id_vendedor` int NOT NULL AUTO_INCREMENT,
  `cedula` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_vendedor`) USING BTREE,
  INDEX `cedula`(`cedula`) USING BTREE,
  CONSTRAINT `vendedores_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `personas` (`cedula`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of vendedores
-- ----------------------------

-- ----------------------------
-- Table structure for venta
-- ----------------------------
DROP TABLE IF EXISTS `venta`;
CREATE TABLE `venta`  (
  `id_recibo_venta` int NOT NULL,
  `id_cliente` int NULL DEFAULT NULL,
  `id_vendedor` int NULL DEFAULT NULL,
  `fecha_de_venta` date NULL DEFAULT NULL,
  `estado` varbinary(15) NULL DEFAULT NULL,
  `Cantidad` int NULL DEFAULT NULL,
  `id_producto` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_recibo_venta`) USING BTREE,
  INDEX `id_cliente`(`id_cliente`) USING BTREE,
  INDEX `id_vendedor`(`id_vendedor`) USING BTREE,
  INDEX `id_producto`(`id_producto`) USING BTREE,
  CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_cliente`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `venta_ibfk_2` FOREIGN KEY (`id_vendedor`) REFERENCES `vendedor` (`id_vendedor`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `venta_ibfk_3` FOREIGN KEY (`id_producto`) REFERENCES `inventario` (`id_producto`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of venta
-- ----------------------------

-- ----------------------------
-- Table structure for ventas
-- ----------------------------
DROP TABLE IF EXISTS `ventas`;
CREATE TABLE `ventas`  (
  `id_venta` int NOT NULL AUTO_INCREMENT,
  `id_cliente` int NULL DEFAULT NULL,
  `id_vendedor` int NULL DEFAULT NULL,
  `id_producto` int NULL DEFAULT NULL,
  `fecha_de_venta` date NULL DEFAULT NULL,
  `estado_venta` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `cantidad` int NULL DEFAULT NULL,
  PRIMARY KEY (`id_venta`) USING BTREE,
  INDEX `id_cliente`(`id_cliente`) USING BTREE,
  INDEX `id_vendedor`(`id_vendedor`) USING BTREE,
  INDEX `id_producto`(`id_producto`) USING BTREE,
  CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `clientes` (`id_cliente`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `ventas_ibfk_2` FOREIGN KEY (`id_vendedor`) REFERENCES `vendedores` (`id_vendedor`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `ventas_ibfk_3` FOREIGN KEY (`id_producto`) REFERENCES `inventarios` (`id_ptoducto`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of ventas
-- ----------------------------

-- ----------------------------
-- Table structure for veterinarios
-- ----------------------------
DROP TABLE IF EXISTS `veterinarios`;
CREATE TABLE `veterinarios`  (
  `id_veterinario` int NOT NULL AUTO_INCREMENT,
  `cedula` varchar(16) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `estado` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_veterinario`) USING BTREE,
  INDEX `cedula`(`cedula`) USING BTREE,
  CONSTRAINT `veterinarios_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `personas` (`cedula`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = DYNAMIC;

-- ----------------------------
-- Records of veterinarios
-- ----------------------------
INSERT INTO `veterinarios` VALUES (1, '489-300301-1003Y', '1');

-- ----------------------------
-- View structure for dgvmascota
-- ----------------------------
DROP VIEW IF EXISTS `dgvmascota`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `dgvmascota` AS select `mascotas`.`id_mascota` AS `id_mascota`,`mascotas`.`nombre_mascota` AS `nombre_mascota`,`tipo_animales`.`descripcion` AS `Tipo_Animal`,`raza`.`raza_descripcion` AS `Raza`,`personas`.`cedula` AS `cedula`,concat_ws(' ',`personas`.`nombre_personas`,`personas`.`apellido_personas`) AS `nombre_propietario` from ((((`mascotas` join `raza`) join `tipo_animales`) join `propietarios`) join `personas`) where ((`mascotas`.`id_raza` = `raza`.`id_raza`) and (`raza`.`id_tipo_animal` = `tipo_animales`.`id_tipo_animal`) and (`mascotas`.`id_propietario` = `propietarios`.`id_propietario`) and (`propietarios`.`cedula` = `personas`.`cedula`));

-- ----------------------------
-- Procedure structure for AddDepartamento
-- ----------------------------
DROP PROCEDURE IF EXISTS `AddDepartamento`;
delimiter ;;
CREATE PROCEDURE `AddDepartamento`(IN `pNombre_Departamento` varchar(30),OUT `pMsj` int)
BEGIN

	DECLARE x int;
	
SELECT COUNT(*) into x FROM departamentos WHERE departamentos.nombre_departamento=pNombre_Departamento;
	if x>0 THEN
		#ya existe
		##13 significa que ya existe el elemento 
		SET pMsj = 13;
	
	ELSE
		INSERT INTO departamentos(nombre_departamento)
		VALUES(pNombre_Departamento);
		##7 significa que se guardo con exito 
		SET pMsj=7;
	END if;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for AddTipo_Animal
-- ----------------------------
DROP PROCEDURE IF EXISTS `AddTipo_Animal`;
delimiter ;;
CREATE PROCEDURE `AddTipo_Animal`(IN `pTipo_Animal` varchar(50),OUT `pMsj` int)
BEGIN

	DECLARE x int;
	
SELECT COUNT(*) into x FROM tipo_animales WHERE tipo_animales.descripcion = pTipo_Animal;
	if x>0 THEN
		#ya existe
		##13 significa que ya existe el elemento 
		SET pMsj = 13;
	
	ELSE
		INSERT INTO tipo_animales(descripcion)
		VALUES(pTipo_Animal);
		##7 significa que se guardo con exito 
		SET pMsj=7;
	END if;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for AddTipo_Telefono
-- ----------------------------
DROP PROCEDURE IF EXISTS `AddTipo_Telefono`;
delimiter ;;
CREATE PROCEDURE `AddTipo_Telefono`(IN `p_descripcion_telefono` varchar(20),OUT `pMsj` int)
BEGIN
	DECLARE x int;
SELECT COUNT(*) into x FROM tipo_telefonos WHERE tipo_telefonos.descripcion= p_descripcion_telefono;
	if x>0 THEN
		#ya existe
		##13 significa que ya existe el elemento 
		SET pMsj = 13;
	
	ELSE
		INSERT INTO tipo_telefonos(descripcion)
		VALUES(p_descripcion_telefono);
		##7 significa que se guardo con exito 
		SET pMsj=7;
	END if;

END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Add_Cita
-- ----------------------------
DROP PROCEDURE IF EXISTS `Add_Cita`;
delimiter ;;
CREATE PROCEDURE `Add_Cita`(IN `pCedula` VARCHAR(16),IN `pId_veterinario` int,IN `pFecha_cita` date,IN `pHora_inicio` time,IN `pHora_final` time,IN `pDecripcion` VARCHAR(250),OUT `pMsj` int)
BEGIN


	DECLARE x int;
	DECLARE y int;
	DECLARE w int;
	START TRANSACTION;
	
	SELECT COUNT(*) INTO w FROM clientes WHERE clientes.cedula = pCedula;
	IF w > 0 THEN
	SELECT id_cliente INTO w FROM clientes WHERE clientes.cedula=pCedula;
ELSE
	INSERT INTO clientes(cedula) VALUES(pCedula);
END IF;

SELECT COUNT(*) INTO x from citas WHERE citas.id_veterinario = pId_veterinario and citas.fecha_cita = pFecha_cita and pHora_inicio BETWEEN hora_inicio and hora_final;

SELECT COUNT(*) INTO y from citas WHERE citas.id_veterinario = pId_veterinario and citas.fecha_cita = pFecha_cita and pHora_final BETWEEN hora_inicio and hora_final;
		
	
	IF (x = 0 and y = 0) THEN
		INSERT INTO citas(id_cliente,id_estado_cita,id_veterinario,fecha_cita,hora_inicio,hora_final,descripcion_cita) VALUES(w,1,pId_veterinario, pFecha_cita,pHora_inicio,pHora_final,pDecripcion);
	SET pMsj = 7;
ELSE IF (x > 0 and y > 0 ) THEN
	SET pMsj = 13;
ELSE IF(x>0) THEN
	SET pMsj = 12;
ELSE
	SET pMsj = 11;
END IF;
END IF;
END IF;




COMMIT;	


END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Add_Cita2
-- ----------------------------
DROP PROCEDURE IF EXISTS `Add_Cita2`;
delimiter ;;
CREATE PROCEDURE `Add_Cita2`(IN `pCedula` VARCHAR(16),IN `pId_veterinario` int,IN `pFecha_cita` date,IN `pHora_inicio` time,IN `pHora_final` time,IN `pDecripcion` VARCHAR(250),OUT `pMsj` int)
BEGIN


	DECLARE x int;
	DECLARE y int;
	DECLARE w int;
	START TRANSACTION;
	
	SELECT COUNT(*) INTO w FROM clientes WHERE clientes.cedula = pCedula;
	IF w > 0 THEN
	SELECT id_cliente INTO w FROM clientes WHERE clientes.cedula=pCedula;
ELSE
	INSERT INTO clientes(cedula) VALUES(pCedula);
END IF;

SELECT COUNT(*) INTO x from citas WHERE citas.id_veterinario = pId_veterinario and citas.fecha_cita = pFecha_cita and pHora_inicio BETWEEN hora_inicio and hora_final;

SELECT COUNT(*) INTO y from citas WHERE citas.id_veterinario = pId_veterinario and citas.fecha_cita = pFecha_cita and pHora_final BETWEEN hora_inicio and hora_final;
		
	
	IF (x = 0 and y = 0) THEN
	INSERT INTO citas(id_cliente,id_veterinario, fecha_cita, hora_inicio, hora_final,descripcion_cita)  VALUES(w, pId_veterinario, pFecha_cita, pHora_inicio, pHora_final, pDecripcion);
	SET pMsj = 7;
ELSE IF (x > 0 and y > 0 ) THEN
	SET pMsj = 13;
ELSE IF(x>0) THEN
	SET pMsj = 12;
ELSE
	SET pMsj = 11;
END IF;
END IF;
END IF;




COMMIT;	

	
	

	


END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Add_Mascota
-- ----------------------------
DROP PROCEDURE IF EXISTS `Add_Mascota`;
delimiter ;;
CREATE PROCEDURE `Add_Mascota`(IN `pNombre_mascota` varchar(50),IN `pidRaza` int,IN `pFecha` date,IN  `pCedula_propietario` varchar(16),IN  `pSexo` varchar(10),OUT `pMsj` varchar(6))
BEGIN
	DECLARE x int;
	
	DECLARE propietarioid int;
	
	START TRANSACTION;
	SET x = 0;
	SELECT COUNT(*) INTO x FROM propietarios WHERE propietarios.cedula = pCedula_propietario;
	IF x = 0 THEN
	INSERT INTO propietarios(cedula) VALUES (pCedula_propietario);
	END IF;
	SELECT id_propietario INTO propietarioid  FROM propietarios WHERE propietarios.cedula = pCedula_propietario;
	set x = 0;
	
	select  COUNT(*) INTO x FROM mascotas WHERE nombre_mascota = pNombre_mascota AND id_raza = pidRaza AND id_propietario = propietarioid;
	
	IF x=0 THEN
	
	INSERT INTO mascotas(nombre_mascota,fecha_nacimiento,id_propietario,sexo,id_raza,Id_estado_mascota)
	VALUES(pNombre_mascota,pFecha,propietarioid,pSexo,pidRaza,1);
	SET pMsj = 7;
	
	ELSE
	SET pMsj = 13;
	END IF;
	
	
	COMMIT;

END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Add_persona
-- ----------------------------
DROP PROCEDURE IF EXISTS `Add_persona`;
delimiter ;;
CREATE PROCEDURE `Add_persona`(IN  `pCedula` varchar(16),IN `pNombre` varchar(20),IN `pApellido` varchar(20),IN `pDireccion` VARCHAR(100),IN `pNumero_Telefono` int,OUT `pMsj` varchar(15),IN `Pid_Tipo_Telefono` INT,IN `pId_Municiopio` int)
BEGIN

	DECLARE x int;
	declare telefonoid , direccionid int;
	START TRANSACTION;
	SET x=0;
	SELECT COUNT(*) INTO x FROM personas WHERE cedula = PCedula;
	IF x=0 THEN
		set x=0;
		SELECT COUNT(*) INTO x FROM telefonos WHERE telefonos.numero_telefono = pNumero_Telefono and telefonos.id_tipo_telefono =   	 Pid_Tipo_Telefono;
	
		IF x=0 THEN 
		#Si no existe destinatarios agrega
		INSERT INTO telefonos(numero_telefono,id_tipo_telefono) VALUES (pNumero_Telefono,Pid_Tipo_Telefono);
		end if;
		
	 SELECT id_telefono INTO telefonoid FROM telefonos WHERE telefonos.numero_telefono = pNumero_Telefono and telefonos.id_tipo_telefono = Pid_Tipo_Telefono;	
	
	
	set x = 0;
	SELECT COUNT(*) INTO x FROM direcciones WHERE direcciones.descripcion_direccion = pDireccion;
	
	IF x=0 THEN 
		INSERT INTO direcciones(descripcion_direccion,id_municipio) VALUES(pDireccion,pId_Municiopio);
		end if;
		
		SELECT id_direccion into direccionid from direcciones WHERE direcciones.descripcion_direccion = pDireccion and 	direcciones.id_municipio = pId_Municiopio;
	
	 INSERT INTO personas(cedula,nombre_personas,apellido_personas,id_telefono,id_direccion) VALUES(pcedula,pNombre,pApellido,telefonoid,direccionid);
	 set pMsj = 7;
	 
	 ELSE
	 SET pMsj = 13;
	 
END IF;

COMMIT;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Add_Raza
-- ----------------------------
DROP PROCEDURE IF EXISTS `Add_Raza`;
delimiter ;;
CREATE PROCEDURE `Add_Raza`(IN `pid_tipo_animal` int,IN `pdescripcion_rasa` varchar(300),OUT `pMsj` int)
BEGIN
	DECLARE x int;
	SELECT COUNT(*) into x FROM raza WHERE id_tipo_animal = pid_tipo_animal and raza_descripcion = pdescripcion_rasa;
	if x>0 THEN
		#ya existe
		##13 significa que ya existe el elemento 
		SET pMsj = 13;
	
	ELSE
	INSERT INTO raza(id_tipo_animal,raza_descripcion)
		VALUES(pid_tipo_animal,pdescripcion_rasa);
		
		##7 significa que se guardo con exito 
		SET pMsj=7;
	END if;

END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Add_Usuario
-- ----------------------------
DROP PROCEDURE IF EXISTS `Add_Usuario`;
delimiter ;;
CREATE PROCEDURE `Add_Usuario`(IN `Pcedula` varchar(16),IN `Palias` varchar(255),IN `Pclave` varchar(255),IN `Pid_tipo_usuario` int,OUT `pMsj` varchar(50))
BEGIN
	DECLARE x INT;
	START TRANSACTION;
	SELECT COUNT(*) INTO x FROM usuarios WHERE usuarios.cedula = Pcedula;
	IF x=0 THEN
	SET x = 0;
			SELECT COUNT(*)INTO x FROM usuarios WHERE usuarios.alias = Palias;
			IF x = 0 THEN
				INSERT INTO usuarios(cedula,alias,clave,id_tipo_usuario,id_estado_usuario) VALUES(Pcedula,Palias,Pclave,Pid_tipo_usuario,2);
				set pMsj =7;
			ELSE
				SET pMsj = 1;##"nombre de usuario ya reguistrado";
		  END IF;

ELSE
	set pMsj = 2;##"cedula ya existe";
END IF;

COMMIT;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Add_Veterinario
-- ----------------------------
DROP PROCEDURE IF EXISTS `Add_Veterinario`;
delimiter ;;
CREATE PROCEDURE `Add_Veterinario`(IN `pCedula` varchar(16),OUT `pMsj` varchar(6))
BEGIN
	
	DECLARE x INT;
	START TRANSACTION;
	SELECT COUNT(*) INTO x FROM veterinarios WHERE veterinarios.cedula = pCedula;
	 
	 if x = 0 THEN 
	 
	 INSERT INTO veterinarios(cedula,estado) VALUES (pCedula,'Disponible');
	 SET pMsj = 7;
	 ELSE
	 SET pMsj = 13;
	 END IF;
	 
	 
COMMIT;
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for capturar_cedula
-- ----------------------------
DROP PROCEDURE IF EXISTS `capturar_cedula`;
delimiter ;;
CREATE PROCEDURE `capturar_cedula`(IN `Palias` varchar(255),IN `Pclave` varchar(255),OUT `pMsj` varchar(50))
BEGIN
DECLARE c VARCHAR(16);
SELECT cedula into c FROM usuarios WHERE usuarios.alias = Palias AND usuarios.clave = Pclave;
	SET pMsj = c;
	
  
END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Editar_Mascota
-- ----------------------------
DROP PROCEDURE IF EXISTS `Editar_Mascota`;
delimiter ;;
CREATE PROCEDURE `Editar_Mascota`(IN `pId_mascota` int,IN `pNombre_Mascota` varchar(50),IN `pId_Raza` int,IN `pFecha_Nacimiento` date,IN `pId_Propietario` int,IN `pEstado` int,IN `pSexo` varchar(50),OUT `pMsj` varchar(10))
BEGIN
	START TRANSACTION;
	UPDATE mascotas SET nombre_mascota = pNombre_Mascota, id_raza = pId_Raza, fecha_nacimiento = pFecha_Nacimiento, id_propietario = pId_Propietario, id_estado_mascota = pEstado, sexo = pSexo WHERE mascotas.id_mascota = pId_mascota;
	
	set pMsj = 13 ;
	
	COMMIT;

END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Loguear_usuario
-- ----------------------------
DROP PROCEDURE IF EXISTS `Loguear_usuario`;
delimiter ;;
CREATE PROCEDURE `Loguear_usuario`(IN `Palias` varchar(255),IN `Pclave` varchar(255),OUT `pMsj` varchar(50))
BEGIN
	
		DECLARE x int;
	DECLARE y int;
	START TRANSACTION;
	SELECT COUNT(*) INTO x FROM usuarios WHERE usuarios.alias = Palias;
	
	IF x = 1 THEN
		SELECT COUNT(*) into x FROM usuarios WHERE usuarios.alias = Palias and usuarios.clave = Pclave;
		IF x > 0 THEN
				SELECT id_tipo_usuario INTO y FROm usuarios WHERE usuarios.alias = Palias and usuarios.clave = Pclave;
				SET pMsj = y;
		ELSE
		set pMsj = 5; ##nombre de usuario o contraseña incorrecto
		
		END IF;

ELSE
	SET pMsj = 5;# nombre de usuario o contraseña incorrecta 
	
END IF;

COMMIT;

END
;;
delimiter ;

-- ----------------------------
-- Procedure structure for Mostrar_mascota
-- ----------------------------
DROP PROCEDURE IF EXISTS `Mostrar_mascota`;
delimiter ;;
CREATE PROCEDURE `Mostrar_mascota`()
BEGIN
SELECT mascotas.id_tipo_animal, descripcion, COUNT(mascotas.id_tipo_animal) as cantidad
FROM mascotas, tipo_animales WHERE mascotas.id_tipo_animal=tipo_animales.id_tipo_animal
GROUP BY id_tipo_animal ORDER BY count(3);

END
;;
delimiter ;

-- ----------------------------
-- Triggers structure for table citas
-- ----------------------------
DROP TRIGGER IF EXISTS `estado_cita`;
delimiter ;;
CREATE TRIGGER `estado_cita` BEFORE INSERT ON `citas` FOR EACH ROW BEGIN


END
;;
delimiter ;

SET FOREIGN_KEY_CHECKS = 1;
