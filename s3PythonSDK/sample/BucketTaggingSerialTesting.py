import boto
from boto.exception import S3ResponseError
from client import conn 
from xml.dom import minidom
from boto.s3.tagging import Tags, TagSet
from boto.s3.connection import Location

 
# test 1. Basic putBucket
    
#      5. Delete Bucket
def main(arg):
    try:
        bucket = conn.create_bucket(arg[0])
        
        print "SetBucketTags"
        
        tag_set = TagSet()
        tag_set.add_tag('key', 'value')
        tags = Tags()
        tags.add_tag_set(tag_set)
        bucket.set_tags(tags)
        
        
        # GetBucketCORS
        print "get_tags"
        
        tags_info = bucket.get_tags()
        print tags_info.to_xml() 
        #for rule in get_cors_cfg:
            #print "AllowedMethod: "+rule.to_xml()
            
         
        # DeleteBucketCORS
        print "delete_tags"
        bucket.delete_tags()
        
        #print "Clean up.."
        conn.delete_bucket(bucket)
        #print " - Bucket logging Serial test done!"
    except S3ResponseError, e:
        xmldoc = minidom.parseString(e.body)
        itemlist = xmldoc.getElementsByTagName('Message')
        print "Status Code: " + repr(e.status)
        print "Reason: " + repr(e.reason)
        print "Message: " + itemlist[0].childNodes[0].nodeValue