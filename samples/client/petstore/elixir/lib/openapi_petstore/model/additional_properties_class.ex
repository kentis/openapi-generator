# NOTE: This file is auto generated by OpenAPI Generator 7.3.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule OpenapiPetstore.Model.AdditionalPropertiesClass do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :map_property,
    :map_of_map_property
  ]

  @type t :: %__MODULE__{
    :map_property => %{optional(String.t) => String.t} | nil,
    :map_of_map_property => %{optional(String.t) => %{optional(String.t) => String.t}} | nil
  }

  def decode(value) do
    value
  end
end

