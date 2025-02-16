namespace HotelsRapidApiProject.Models
{
    public class GetHotelDetailViewModel
    {
        public class Rootobject
        {
            public bool status { get; set; }
            public string message { get; set; }
            public long timestamp { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public int ufi { get; set; }
            public int hotel_id { get; set; }
            public string hotel_name { get; set; }
            public string url { get; set; }
            public string hotel_name_trans { get; set; }
            public int review_nr { get; set; }
            public string arrival_date { get; set; }
            public string departure_date { get; set; }
            public string price_transparency_mode { get; set; }
            public string accommodation_type_name { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
            public string address { get; set; }
            public string address_trans { get; set; }
            public string city { get; set; }
            public string city_trans { get; set; }
            public string city_in_trans { get; set; }
            public string city_name_en { get; set; }
            public object district { get; set; }
            public string countrycode { get; set; }
            public float distance_to_cc { get; set; }
            public string default_language { get; set; }
            public string country_trans { get; set; }
            public string currency_code { get; set; }
            public string zip { get; set; }
            public string timezone { get; set; }
            public int soldout { get; set; }
            public int available_rooms { get; set; }
            public int max_rooms_in_reservation { get; set; }
            public string average_room_size_for_ufi_m2 { get; set; }
            public int is_family_friendly { get; set; }
            public int is_closed { get; set; }
            public int is_crimea { get; set; }
            public int is_hotel_ctrip { get; set; }
            public int is_price_transparent { get; set; }
            public int is_genius_deal { get; set; }
            public int is_cash_accepted_check_enabled { get; set; }
            public int qualifies_for_no_cc_reservation { get; set; }
            public int hotel_include_breakfast { get; set; }
            public string cc1 { get; set; }
            public string[] family_facilities { get; set; }
            public Property_Highlight_Strip[] property_highlight_strip { get; set; }
            public Facilities_Block facilities_block { get; set; }
            public Top_Ufi_Benefits[] top_ufi_benefits { get; set; }
            public Languages_Spoken languages_spoken { get; set; }
            public string[] spoken_languages { get; set; }
            public Breakfast_Review_Score breakfast_review_score { get; set; }
            public Wifi_Review_Score wifi_review_score { get; set; }
            public Min_Room_Distribution min_room_distribution { get; set; }
            public Booking_Home booking_home { get; set; }
            public Aggregated_Data aggregated_data { get; set; }
            public Last_Reservation last_reservation { get; set; }
            public Free_Facilities_Cancel_Breakfast[] free_facilities_cancel_breakfast { get; set; }
            public Hotel_Text hotel_text { get; set; }
            public int[] districts { get; set; }
            public object[] preferences { get; set; }
            public Hotel_Important_Information_With_Codes[] hotel_important_information_with_codes { get; set; }
            public object[] block { get; set; }
            public Rawdata rawData { get; set; }
        }

        public class Facilities_Block
        {
            public Facility[] facilities { get; set; }
            public string name { get; set; }
            public string type { get; set; }
        }

        public class Facility
        {
            public string icon { get; set; }
            public string name { get; set; }
        }

        public class Languages_Spoken
        {
            public string[] languagecode { get; set; }
        }

        public class Breakfast_Review_Score
        {
            public string review_snippet { get; set; }
            public int review_score { get; set; }
            public int review_number { get; set; }
            public string review_score_word { get; set; }
            public int rating { get; set; }
            public int review_count { get; set; }
        }

        public class Wifi_Review_Score
        {
            public float rating { get; set; }
        }

        public class Min_Room_Distribution
        {
            public int adults { get; set; }
            public object[] children { get; set; }
        }

        public class Booking_Home
        {
        }

        public class Aggregated_Data
        {
            public int has_kitchen { get; set; }
            public int has_seating { get; set; }
            public int has_refundable { get; set; }
            public int has_nonrefundable { get; set; }
            public object[] common_kitchen_fac { get; set; }
        }

        public class Last_Reservation
        {
            public object countrycode { get; set; }
            public object country { get; set; }
            public string time { get; set; }
        }

        public class Hotel_Text
        {
        }

        public class Rawdata
        {
            public string checkoutDate { get; set; }
            public string name { get; set; }
            public Checkout checkout { get; set; }
            public string currency { get; set; }
            public int mainPhotoId { get; set; }
            public bool isHighlightedHotel { get; set; }
            public float latitude { get; set; }
            public string checkinDate { get; set; }
            public int rankingPosition { get; set; }
            public int id { get; set; }
            public string[] photoUrls { get; set; }
            public int ufi { get; set; }
            public float longitude { get; set; }
            public string wishlistName { get; set; }
            public int qualityClass { get; set; }
            public int propertyClass { get; set; }
            public Checkin checkin { get; set; }
            public object[] blockIds { get; set; }
            public int reviewCount { get; set; }
            public string reviewScoreWord { get; set; }
            public float reviewScore { get; set; }
            public bool isFirstPage { get; set; }
            public int optOutFromGalleryChanges { get; set; }
            public string countryCode { get; set; }
            public bool isSoldout { get; set; }
            public int position { get; set; }
            public int accuratePropertyClass { get; set; }
        }

        public class Checkout
        {
            public string fromTime { get; set; }
            public string untilTime { get; set; }
        }

        public class Checkin
        {
            public string fromTime { get; set; }
            public string untilTime { get; set; }
        }

        public class Property_Highlight_Strip
        {
            public Icon_List[] icon_list { get; set; }
            public string name { get; set; }
        }

        public class Icon_List
        {
            public int size { get; set; }
            public string icon { get; set; }
        }

        public class Top_Ufi_Benefits
        {
            public string icon { get; set; }
            public string translated_name { get; set; }
        }

        public class Free_Facilities_Cancel_Breakfast
        {
            public int facility_id { get; set; }
        }

        public class Hotel_Important_Information_With_Codes
        {
            public string phrase { get; set; }
            public int executing_phase { get; set; }
            public int sentence_id { get; set; }
        }

    }
}
