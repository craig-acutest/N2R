using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;

namespace N2R.Utilities
{
    public static class AmazonS3Storage
    {
        public static bool UploadFile(string FilePath, string FileName, string BucketName)
        {
            bool upload = false;
            try
            {
                var s3 = Amazon.AWSClientFactory.CreateAmazonS3Client(ConfigurationManager.AppSettings["AWSAccessKey"], ConfigurationManager.AppSettings["AWSSecretKey"]);
                PutObjectRequest request = new PutObjectRequest();
                request.WithKey(FileName);
                request.WithFilePath(FilePath);
                request.WithBucketName(BucketName);
                request.CannedACL = S3CannedACL.PublicRead;
                request.StorageClass = S3StorageClass.Standard;

                s3.PutObject(request);
                s3.Dispose();

                upload = true;
            }
            catch (AmazonS3Exception ex)
            {
                //Process.CalibrationProcess csProcess = new CalibrationProcess();

                //emailError("UploadFile", "Error: " + ex.ToString());
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }
            return upload;
        }

        public static bool UploadFile(Stream stream, string FileName, string BucketName)
        {
            bool upload = false;
            try
            {
                var s3 = Amazon.AWSClientFactory.CreateAmazonS3Client(ConfigurationManager.AppSettings["AWSAccessKey"], ConfigurationManager.AppSettings["AWSSecretKey"]);
                PutObjectRequest request = new PutObjectRequest();
                request.WithKey(FileName);
                request.WithInputStream(stream);
                request.WithBucketName(BucketName);
                request.CannedACL = S3CannedACL.PublicRead;
                request.StorageClass = S3StorageClass.Standard;

                s3.PutObject(request);
                s3.Dispose();

                upload = true;
            }
            catch (AmazonS3Exception ex)
            {
                //Process.CalibrationProcess csProcess = new CalibrationProcess();

                //emailError("UploadFile", "Error: " + ex.ToString());
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
            }
            return upload;
        }

        public static bool FileExist(string FileName, string Bucketname)
        {
            bool fileFound = true;

            var s3 = Amazon.AWSClientFactory.CreateAmazonS3Client(RegionEndpoint.EUWest1);

            GetObjectMetadataResponse response = new GetObjectMetadataResponse();

            try
            {
                response = s3.GetObjectMetadata(new GetObjectMetadataRequest()
                   .WithBucketName(Bucketname)
                   .WithKey(FileName));

                fileFound = true;
            }

            catch (Amazon.S3.AmazonS3Exception ex)
            {
                if (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
                    fileFound = false;

                //status wasn't not found, so throw the exception
                //throw;
            }

            return fileFound;
        }

        public static bool DeleteFile(string FileName, string BucketName)
        {
            bool deleted = false;

            if (fileExist(FileName, BucketName))
            {
                try
                {
                    var s3 = Amazon.AWSClientFactory.CreateAmazonS3Client(ConfigurationManager.AppSettings["AWSAccessKey"], ConfigurationManager.AppSettings["AWSSecretKey"]);
                    DeleteObjectRequest request = new DeleteObjectRequest();
                    request.WithKey(FileName);
                    request.WithBucketName(BucketName);

                    s3.DeleteObject(request);
                    s3.Dispose();

                    deleted = true;
                }
                catch (AmazonS3Exception ex)
                {
                    //Process.CalibrationProcess csProcess = new CalibrationProcess();

                    //emailError("UploadFile", "Error: " + ex.ToString());
                    Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                }
                return deleted;
            }
            else
            {
                return deleted;
            }
        }

        public static List<S3Object> GetFolder(string folderPath, string BucketName)
        {
            var s3 = Amazon.AWSClientFactory.CreateAmazonS3Client(ConfigurationManager.AppSettings["AWSAccessKey"], ConfigurationManager.AppSettings["AWSSecretKey"]);

            List<S3Object> folderList = new List<S3Object>();

            using (s3)
            {
                try
                {
                    ListObjectsRequest Lor = new ListObjectsRequest()
                    {
                        BucketName = BucketName,
                        // with Prefix is a folder Key, it will list only child of that folder
                        Prefix = folderPath,
                        //with Delimiter is '/', it will not get folder.
                        Delimiter = "/"
                    };
                    ListObjectsResponse response1 = s3.ListObjects(Lor);
                    foreach (S3Object s3Object in response1.S3Objects)
                    {
                        //Do anything you want
                        folderList.Add(s3Object);
                    }
                }
                catch (AmazonS3Exception ex)
                {
                    //Show Exception
                    Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                }
            }

            return folderList;
        }
    }
}