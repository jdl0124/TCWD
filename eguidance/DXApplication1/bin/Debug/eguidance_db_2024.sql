/*
 Navicat Premium Data Transfer

 Source Server         : ZINAI_SERVER
 Source Server Type    : MySQL
 Source Server Version : 100140
 Source Host           : 119.92.208.234:3306
 Source Schema         : eguidance_db_2024

 Target Server Type    : MySQL
 Target Server Version : 100140
 File Encoding         : 65001

 Date: 06/07/2024 17:33:49
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for cache_locks
-- ----------------------------
DROP TABLE IF EXISTS `cache_locks`;
CREATE TABLE `cache_locks`  (
  `key` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `owner` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `expiration` int(11) NOT NULL,
  PRIMARY KEY (`key`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for eg_cache
-- ----------------------------
DROP TABLE IF EXISTS `eg_cache`;
CREATE TABLE `eg_cache`  (
  `key` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `value` mediumtext CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `expiration` int(11) NOT NULL,
  PRIMARY KEY (`key`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for eg_failed_jobs
-- ----------------------------
DROP TABLE IF EXISTS `eg_failed_jobs`;
CREATE TABLE `eg_failed_jobs`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `uuid` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `connection` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `queue` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `payload` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `exception` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `failed_at` timestamp(0) NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`) USING BTREE,
  UNIQUE INDEX `eg_failed_jobs_uuid_unique`(`uuid`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for eg_job_batches
-- ----------------------------
DROP TABLE IF EXISTS `eg_job_batches`;
CREATE TABLE `eg_job_batches`  (
  `id` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `total_jobs` int(11) NOT NULL,
  `pending_jobs` int(11) NOT NULL,
  `failed_jobs` int(11) NOT NULL,
  `failed_job_ids` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `options` mediumtext CHARACTER SET utf8 COLLATE utf8_general_ci NULL,
  `cancelled_at` int(11) NULL DEFAULT NULL,
  `created_at` int(11) NOT NULL,
  `finished_at` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for eg_jobs
-- ----------------------------
DROP TABLE IF EXISTS `eg_jobs`;
CREATE TABLE `eg_jobs`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `queue` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `payload` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `attempts` tinyint(3) UNSIGNED NOT NULL,
  `reserved_at` int(10) UNSIGNED NULL DEFAULT NULL,
  `available_at` int(10) UNSIGNED NOT NULL,
  `created_at` int(10) UNSIGNED NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `eg_jobs_queue_index`(`queue`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for eguidance_password_reset_tokens
-- ----------------------------
DROP TABLE IF EXISTS `eguidance_password_reset_tokens`;
CREATE TABLE `eguidance_password_reset_tokens`  (
  `email` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `token` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`email`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for eguidance_users
-- ----------------------------
DROP TABLE IF EXISTS `eguidance_users`;
CREATE TABLE `eguidance_users`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `email` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `email_verified_at` timestamp(0) NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  UNIQUE INDEX `eguidance_users_email_unique`(`email`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for entry_adequateinformation
-- ----------------------------
DROP TABLE IF EXISTS `entry_adequateinformation`;
CREATE TABLE `entry_adequateinformation`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `EDP_NO` varchar(9) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `adeqinfo_code` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `isdeleted` int(11) NOT NULL DEFAULT 0,
  `entryipadd` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for entry_awardsrecognitions
-- ----------------------------
DROP TABLE IF EXISTS `entry_awardsrecognitions`;
CREATE TABLE `entry_awardsrecognitions`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `EDP_NO` varchar(9) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `awardsrecog_code` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `isdeleted` int(11) NOT NULL DEFAULT 0,
  `entryipadd` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for entry_decision2enrol
-- ----------------------------
DROP TABLE IF EXISTS `entry_decision2enrol`;
CREATE TABLE `entry_decision2enrol`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `EDP_NO` varchar(9) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `decs2enrol_code` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `isdeleted` int(11) NOT NULL DEFAULT 0,
  `entryipadd` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for entry_orgcodes
-- ----------------------------
DROP TABLE IF EXISTS `entry_orgcodes`;
CREATE TABLE `entry_orgcodes`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `EDP_NO` varchar(9) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `org_code` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `isdeleted` int(11) NOT NULL DEFAULT 0,
  `entryipadd` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for entry_seminaractivities
-- ----------------------------
DROP TABLE IF EXISTS `entry_seminaractivities`;
CREATE TABLE `entry_seminaractivities`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `EDP_NO` varchar(9) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `seminar_act_code` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `isdeleted` int(11) NOT NULL DEFAULT 0,
  `entryipadd` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for entry_testingservices
-- ----------------------------
DROP TABLE IF EXISTS `entry_testingservices`;
CREATE TABLE `entry_testingservices`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `EDP_NO` varchar(9) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `testing_code` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `isdeleted` int(11) NOT NULL DEFAULT 0,
  `entryipadd` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for lib_adequateinformation
-- ----------------------------
DROP TABLE IF EXISTS `lib_adequateinformation`;
CREATE TABLE `lib_adequateinformation`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `adeqinfo_code` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `adeqinfo_name` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `libstat` int(11) NOT NULL DEFAULT 0,
  `entryipadd` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for lib_awardsrecognitions
-- ----------------------------
DROP TABLE IF EXISTS `lib_awardsrecognitions`;
CREATE TABLE `lib_awardsrecognitions`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `awardsrecog_code` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `awardsrecog_name` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `libstat` int(11) NOT NULL DEFAULT 0,
  `entryipadd` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for lib_decision2enrol
-- ----------------------------
DROP TABLE IF EXISTS `lib_decision2enrol`;
CREATE TABLE `lib_decision2enrol`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `decs2enrol_code` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `decs2enrol_name` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `libstat` int(11) NOT NULL DEFAULT 0,
  `entryipadd` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for lib_orgcodes
-- ----------------------------
DROP TABLE IF EXISTS `lib_orgcodes`;
CREATE TABLE `lib_orgcodes`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `org_code` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `org_name` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `libstat` int(11) NOT NULL DEFAULT 0,
  `entryipadd` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for lib_seminaractivities
-- ----------------------------
DROP TABLE IF EXISTS `lib_seminaractivities`;
CREATE TABLE `lib_seminaractivities`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `seminar_act_code` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `serminar_act_name` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `libstat` int(11) NOT NULL DEFAULT 0,
  `entryipadd` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for lib_testingservices
-- ----------------------------
DROP TABLE IF EXISTS `lib_testingservices`;
CREATE TABLE `lib_testingservices`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `testing_code` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `testing_name` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `testing_desc` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `libstat` int(11) NOT NULL DEFAULT 0,
  `entryipadd` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Table structure for migrations
-- ----------------------------
DROP TABLE IF EXISTS `migrations`;
CREATE TABLE `migrations`  (
  `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  `migration` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `batch` int(11) NOT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 9 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of migrations
-- ----------------------------
INSERT INTO `migrations` VALUES (4, '2024_04_22_064429_eguidance_libraries', 1);
INSERT INTO `migrations` VALUES (5, '2024_04_23_034700_eguidance_data_entry', 1);
INSERT INTO `migrations` VALUES (6, '0001_01_01_000000_create_users_table', 2);
INSERT INTO `migrations` VALUES (7, '0001_01_01_000001_create_cache_table', 2);
INSERT INTO `migrations` VALUES (8, '0001_01_01_000002_create_jobs_table', 2);

-- ----------------------------
-- Table structure for sessions
-- ----------------------------
DROP TABLE IF EXISTS `sessions`;
CREATE TABLE `sessions`  (
  `id` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `user_id` bigint(20) UNSIGNED NULL DEFAULT NULL,
  `ip_address` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `user_agent` text CHARACTER SET utf8 COLLATE utf8_general_ci NULL,
  `payload` longtext CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `last_activity` int(11) NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `sessions_user_id_index`(`user_id`) USING BTREE,
  INDEX `sessions_last_activity_index`(`last_activity`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of sessions
-- ----------------------------
INSERT INTO `sessions` VALUES ('1Mi85WImkSH3mKohDH5Qe9piccbkgaGCtztmsDZu', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36', 'YTozOntzOjY6Il90b2tlbiI7czo0MDoialJEU0d0U2JHYVoySzNXZW1FNE5kTElhUU5ISjlVRXVna09iamN5VCI7czo5OiJfcHJldmlvdXMiO2E6MTp7czozOiJ1cmwiO3M6MjE6Imh0dHA6Ly8xMjcuMC4wLjE6ODAwMCI7fXM6NjoiX2ZsYXNoIjthOjI6e3M6Mzoib2xkIjthOjA6e31zOjM6Im5ldyI7YTowOnt9fX0=', 1717553479);
INSERT INTO `sessions` VALUES ('4pck53H8zGoUnDEUA6N2Sy4NvgS9gSTEEwthT7Eq', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36', 'YTozOntzOjY6Il90b2tlbiI7czo0MDoiVjNBYzBOb0lvNVZHNGR1cHlqcTVWbGxWamQxS2pOS1N3T2c2YkFJMSI7czo5OiJfcHJldmlvdXMiO2E6MTp7czozOiJ1cmwiO3M6MjE6Imh0dHA6Ly8xMjcuMC4wLjE6ODAwMCI7fXM6NjoiX2ZsYXNoIjthOjI6e3M6Mzoib2xkIjthOjA6e31zOjM6Im5ldyI7YTowOnt9fX0=', 1718357576);
INSERT INTO `sessions` VALUES ('iNUQvvXzzJV8jsi75Cl6Tvm9VhOBBDyVa37tTCQ5', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36', 'YTozOntzOjY6Il90b2tlbiI7czo0MDoiR0s1WFVCOVdMMExERVBOaGxzMXcyMDRmWklYRXczOFJ1QXN2andvRSI7czo5OiJfcHJldmlvdXMiO2E6MTp7czozOiJ1cmwiO3M6MjE6Imh0dHA6Ly8xMjcuMC4wLjE6ODAwMCI7fXM6NjoiX2ZsYXNoIjthOjI6e3M6Mzoib2xkIjthOjA6e31zOjM6Im5ldyI7YTowOnt9fX0=', 1718075550);
INSERT INTO `sessions` VALUES ('NftQpjAO7wvptrVsBur6LoaEBkFwBHeNdVLT8nnY', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36', 'YTozOntzOjY6Il90b2tlbiI7czo0MDoiUXNLM0VLa3JQNUJiM0twSlZiaHBrMDNzU1dJRkVZSlNDV2RlZElUcCI7czo5OiJfcHJldmlvdXMiO2E6MTp7czozOiJ1cmwiO3M6MjE6Imh0dHA6Ly8xMjcuMC4wLjE6ODAwMCI7fXM6NjoiX2ZsYXNoIjthOjI6e3M6Mzoib2xkIjthOjA6e31zOjM6Im5ldyI7YTowOnt9fX0=', 1718237884);

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users`  (
  `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `email_verified_at` timestamp(0) NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NULL DEFAULT NULL,
  `created_at` timestamp(0) NULL DEFAULT NULL,
  `updated_at` timestamp(0) NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = Compact;

SET FOREIGN_KEY_CHECKS = 1;
