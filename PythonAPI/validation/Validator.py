import json
import jsonschema
from lxml import etree
import os

# File paths
current_directory = os.path.dirname(__file__)
json_file_path_upload = os.path.join(current_directory, 'JSON', 'upload_schema.json')
json_file_path_modules = os.path.join(current_directory, 'JSON', 'modules_summary_schema.json')
json_file_path_add_member = os.path.join(current_directory, 'JSON', 'add_member_schema.json')
json_file_path_login = os.path.join(current_directory, 'JSON', 'login_schema.json')
json_file_path_register = os.path.join(current_directory, 'JSON', 'register_schema.json')
xsd_file_path_modules = os.path.join(current_directory, 'XML', 'modules_summary_schema.xsd')
xsd_file_path_add_member = os.path.join(current_directory, 'XML', 'add_member_schema.xsd')
xsd_file_path_login = os.path.join(current_directory, 'XML', 'login_schema.xsd')
xsd_file_path_register = os.path.join(current_directory, 'XML', 'register_schema.xsd')


# JSON Validation
def json_schema_validate(json_file, schemapath):
    with open(schemapath, 'r') as f:
        schema = json.load(f)

    try:
        jsonschema.validate(json_file, schema)
        return True
    except jsonschema.exceptions.ValidationError as e:
        print(e)
        return False


# XML Validation
def xml_schema_validate(file, schemapath):
    xml = etree.fromstring(file)

    with open(schemapath, 'r') as f:
        xsd = etree.parse(f)

    schema = etree.XMLSchema(xsd)
    try:
        schema.assertValid(xml)
        return True
    except etree.XMLSyntaxError as e:
        raise Exception('Malformed XML. %s' % e)
    except etree.DocumentInvalid as e:
        raise Exception('Invalid XML. %s' % e)
