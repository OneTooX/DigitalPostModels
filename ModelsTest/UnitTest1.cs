using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModelsTest
{
    using System;
    using System.Text.Json;

    using OneTooX.DigitalPost.Model.Result;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDeserializeContactPointResult()
        {
            var resString = "{  \"currentPage\" : 0,  \"totalPages\" : 1,  \"elementsOnPage\" : 1,  \"totalElements\" : 1,  \"contactPoints\" : [ {    \"id\" : \"163710ae-5078-350c-0000-000000000440\",    \"name\" : \"Kontanthjælp og sygedagpenge\",    \"description\" : \"Change me\",    \"targets\" : [ \"CITIZEN\", \"AUTHORITY\", \"COMPANY\" ],    \"memoSizeThresholdMB\" : 10.0,    \"allowedNumberOfAttachments\" : 99,    \"active\" : false,    \"visible\" : true,    \"organisationId\" : \"14d6e9ad-fc0e-3918-0000-0000000001f8\",    \"contactPointCodes\" : [ ],    \"contactGroups\" : [ {      \"id\" : \"fd8ca657-157c-3ffe-0000-000000001745\",      \"organisationalUnit\" : false,      \"name\" : \"Borger\",      \"description\" : \"Change me\",      \"organisation\" : {        \"id\" : \"14d6e9ad-fc0e-3918-0000-0000000001f8\",        \"name\" : \"Albertslund Kommune\",        \"cvrNumber\" : \"66137112\",        \"type\" : \"AUTHORITY\",        \"authorityType\" : \"MUNICIPALITY\",        \"authorityTerms\" : true,        \"logoAvailable\" : false,        \"targets\" : [ ],        \"rightsIntroductionCompleted\" : false      },      \"parent\" : {        \"id\" : \"fd8ca657-157c-3ffe-0000-000000000630\",        \"organisationalUnit\" : false,        \"name\" : \"Albertslund Kommune\",        \"description\" : \"Change me\",        \"organisation\" : {          \"id\" : \"14d6e9ad-fc0e-3918-0000-0000000001f8\",          \"name\" : \"Albertslund Kommune\",          \"cvrNumber\" : \"66137112\",          \"type\" : \"AUTHORITY\",          \"authorityType\" : \"MUNICIPALITY\",          \"authorityTerms\" : true,          \"logoAvailable\" : false,          \"targets\" : [ ],          \"rightsIntroductionCompleted\" : false        },        \"targets\" : [ ],        \"postkasseIds\" : [ ]      },      \"targets\" : [ ],      \"postkasseIds\" : [ ]    } ],    \"recommendedAttributes\" : [ ],    \"searchTerms\" : [ ],    \"translations\" : [ ]  } ]}";
            var obj = JsonSerializer.Deserialize<ContactPointsResult>(resString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            Assert.IsNotNull(obj);
            Assert.IsNotNull(obj.ContactPoints);
            Assert.AreEqual(1, obj.ContactPoints.Length);
            Assert.AreEqual(Guid.Parse("163710ae-5078-350c-0000-000000000440"), obj.ContactPoints[0].Id);
        }
    }
}
