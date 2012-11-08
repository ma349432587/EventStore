﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace EventStore.Core.Tests.Services.Storage.MaxAgeMaxCount.ReadRange_And_NextEventNumber
{
    public class when_reading_stream_with_max_age: ReadIndexTestScenario
    {
        
        protected override void WriteTestScenario()
        {
            var now = DateTime.UtcNow;

            WriteStreamCreated("ES", @"{""$maxAge"":20}", now.AddSeconds(-100));
            WriteSingleEvent("ES", 1, "bla", now.AddSeconds(-50));
            WriteSingleEvent("ES", 2, "bla", now.AddSeconds(-25));
            WriteSingleEvent("ES", 3, "bla", now.AddSeconds(-15));
            WriteSingleEvent("ES", 4, "bla", now.AddSeconds(-11));
            WriteSingleEvent("ES", 5, "bla", now.AddSeconds(-3));
        }

        [Test]
        public void on_read_forward_from_start_to_expired_next_event_number_is_expired_plus_1_and_its_not_end_of_stream()
        {
        }

        [Test]
        public void on_read_forward_from_start_to_active_next_event_number_is_last_read_event_plus_1_and_its_not_end_of_stream()
        {
        }

        [Test]
        public void on_read_forward_from_expired_to_active_next_event_number_is_last_read_event_plus_1_and_its_not_end_of_stream()
        {
        }

        [Test]
        public void on_read_forward_from_expired_to_end_next_event_number_is_end_plus_1_and_its_end_of_stream()
        {
        }

        [Test]
        public void on_read_forward_from_expired_to_out_of_bounds_next_event_number_is_end_plus_1_and_its_end_of_stream()
        {
        }

        [Test]
        public void on_read_forward_from_out_of_bounds_to_out_of_bounds_next_event_number_is_end_plus_1_and_its_end_of_stream()
        {
        }


        [Test]
        public void on_read_backward_from_end_to_active_next_event_number_is_last_read_event_minus_1_and_its_not_end_of_stream()
        {
        }

        [Test]
        public void on_read_backward_from_end_to_maxage_bound_next_event_number_is_maxage_bound_minus_1_and_its_not_end_of_stream() // just no way to tell this
        {
        }

        [Test]
        public void on_read_backward_from_active_to_expired_its_end_of_stream()
        {
        }

        [Test]
        public void on_read_backward_from_expired_to_expired_its_end_of_stream()
        {
        }

        [Test]
        public void on_read_backward_from_expired_to_before_start_its_end_of_stream()
        {
        }

        [Test]
        public void on_read_backward_from_out_of_bounds_to_out_of_bounds_next_event_number_is_end_and_its_not_end_of_stream()
        {
        }
    }
}
